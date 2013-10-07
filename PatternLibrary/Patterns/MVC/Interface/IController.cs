namespace PatternLibrary.Patterns.MVC.Interface
{
    public interface IController
    {
        void Start();
        void Stop();
        void IncreaseBPM();
        void DecreaseBPM();
        void SetBPM(int bpm);
    }
}