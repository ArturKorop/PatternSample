using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.Practices.Unity;

namespace Common.Code
{
    /// <summary>
    /// Support class for work with text and xml
    /// Default using <see cref="ConsoleTextProvider"/>
    /// 
    /// Must to be configurate before or during using. 
    /// By setting <see cref="ITextProvider"/>
    /// </summary>
    public static class Support
    {
        #region Text

        private static ITextProvider _provider;

        private static ITextProvider Provider
        {
            get { return _provider; }
        }

        /// <summary>
        /// Print this obj.ToString() to current <see cref="ITextProvider"/>
        /// </summary>
        /// <typeparam name="T">Any type</typeparam>
        /// <param name="obj">Object to print</param>
        public static void Print<T>(this T obj)
        {

            obj.ToString().Print();
        }

        /// <summary>
        /// Print this format and arguments to current <see cref="ITextProvider"/>
        /// </summary>
        /// <param name="format">String presentation of format, like "Result: {0}" etc</param>
        /// <param name="args">Arguments for current format</param>
        public static void Print(this string format, params object[] args)
        {
            Provider.WriteLine(format, args);
        }

        /// <summary>
        /// Wrap for <see cref="Print(string, object[])"/>
        /// </summary>
        /// <param name="format">String presentation of format, like "Result: {0}" etc</param>
        /// <param name="args">Arguments for current format</param>
        public static void P(this string format, params object[] args)
        {
            format.Print(args);
        }

        /// <summary>
        /// Wrap for <see cref="Print{T}"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public static void P<T>(this T obj)
        {
            obj.ToString().Print();
        }

        /// <summary>
        /// Call of method Wait in current <see cref="ITextProvider"/>
        /// </summary>
        public static void Wait()
        {
            Provider.Wait();
        }

        #endregion

        #region Serializations

        /// <summary>
        /// Serialize object to <see cref="XElement"/>
        /// </summary>
        /// <typeparam name="T">Any type of object</typeparam>
        /// <param name="obj">Object of current type</param>
        /// <returns><see cref="XElement"/> view of object</returns>
        public static XElement ToXml<T>(this T obj)
        {
            using (var stream = new MemoryStream())
            {
                var serializer = new XmlSerializer(typeof (T));
                serializer.Serialize(stream, obj);
                stream.Position = 0;
                using (var reader = new StreamReader(stream))
                {
                    var str = reader.ReadToEnd();
                    return XElement.Parse(str);
                }
            }
        }

        /// <summary>
        /// Deserialize <see cref="XElement"/> to object
        /// </summary>
        /// <typeparam name="T">Any class</typeparam>
        /// <param name="xml"><see cref="XElement"/> view of object</param>
        /// <returns>Instance</returns>
        public static T FromXml<T>(this XElement xml) where T : class
        {
            using (var stream = new StringReader(xml.ToString()))
            {
                var serializer = new XmlSerializer(typeof (T));
                var result = serializer.Deserialize(stream);
                if (result != null)
                    return (T) result;
                return null;
            }
        }

        #endregion

        #region Configuration

        /// <summary>
        /// Configure current <see cref="ITextProvider"/>
        /// with data from <see cref="DIServiceLocator"/>
        /// </summary>
        public static void Configure()
        {
            _provider = DIServiceLocator.Current.Resolve<ITextProvider>();
        }

        #endregion
    }
}