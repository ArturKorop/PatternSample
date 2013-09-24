using System.Threading;
using Common.Code;

namespace PatternLibrary.Patterns.Singleton.Code
{
    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;
        private static volatile ChocolateBoiler _instace;
        private static readonly object SynkRoot = new object();

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get
            {
                if (_instace == null)
                {
                    lock (SynkRoot)
                    {
                        if (_instace == null)
                            _instace = new ChocolateBoiler();
                    }
                }

                return _instace;
            }
        }

        public void Fill(string owner)
        {
            lock (SynkRoot)
            {
                if (!_empty) return;

                Thread.Sleep(100);
                _empty = false;
                _boiled = true;
                "Fill successful {0}".P(owner);
            }
        }

        public void Drain(string owner)
        {
            lock (SynkRoot)
            {
                if (_empty || !_boiled) return;

                Thread.Sleep(100);
                _empty = true;
                "Drain successful {0}".P(owner);
            }
        }
    }
}