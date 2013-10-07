using Common.Code;
using PatternLibrary.Patterns.MVC.Interface;

namespace PatternLibrary.Patterns.MVC.Code.BPMObservers
{
    public class ConsoleBPMObserver : IBPMObserver
    {
        public void UpdateBPM(int bpm)
        {
            "Current BPM: {0}".P(bpm);
        }

        public void UpdateTempo(int tempo)
        {
            "CurrentTempo: {0}".P(tempo);
        }
    }
}