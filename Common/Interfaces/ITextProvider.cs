namespace Common.Interfaces
{
    public interface ITextProvider
    {
        void WriteLine(string format, params object[] args);
        void Wait();
    }
}