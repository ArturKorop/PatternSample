using System;

namespace PatternLibrary.Patterns.MVC.Interface
{
    public interface ISequencer
    {
        void Start();
        void Stop();
        void SetTempInBPM(int bpm);
        int GetTempo();
        event Action<int> ChangeTempo;
    }
}