namespace PatternLibrary.Patterns.MVC.Interface
{
    public interface IBeatModel
    {
        void Initialize();
        void On();
        void Off();
        void SetBPM(int bpm);
        int GetBPM();
        void RegisterObserver(IBeatObserver observer);
        void RegisterObserver(IBPMObserver observer);
        void RemoveObserver(IBeatObserver observer);
        void RemoveObserver(IBPMObserver observer);
    }
}