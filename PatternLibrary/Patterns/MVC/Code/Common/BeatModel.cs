using System.Collections.Generic;
using Common.Code.Configuration;
using Microsoft.Practices.Unity;
using PatternLibrary.Patterns.MVC.Interface;

namespace PatternLibrary.Patterns.MVC.Code.Common
{
    public class BeatModel : IBeatModel
    {
        private ISequencer _sequencer;
        readonly List<IBeatObserver> _beatObservers = new List<IBeatObserver>();
        readonly List<IBPMObserver> _bpmObservers = new List<IBPMObserver>();
        private int _bpm = 90;

        public void Initialize()
        {
            _sequencer = DIServiceLocator.Current.Resolve<ISequencer>();
            _sequencer.ChangeTempo += SequencerOnChangeTempo;
        }

        private void SequencerOnChangeTempo(int i)
        {
            NotifyBPMObservers(i);
        }

        private void NotifyBPMObservers(int i)
        {
            foreach (var bpmObserver in _bpmObservers)
            {
                bpmObserver.UpdateBPM(_bpm);
                bpmObserver.UpdateTempo(i);
            }
        }

        public void On()
        {
            _sequencer.Start();
            SetBPM(90);
        }

        public void Off()
        {
            SetBPM(0);
            _sequencer.Stop();
        }

        public void SetBPM(int bpm)
        {
            _bpm = bpm;
            _sequencer.SetTempInBPM(_bpm);
        }

        public int GetBPM()
        {
            return _bpm;
        }

        public void RegisterObserver(IBeatObserver observer)
        {
            _beatObservers.Add(observer);
        }

        public void RegisterObserver(IBPMObserver observer)
        {
            _bpmObservers.Add(observer);
        }

        public void RemoveObserver(IBeatObserver observer)
        {
            _beatObservers.Remove(observer);
        }

        public void RemoveObserver(IBPMObserver observer)
        {
            _bpmObservers.Remove(observer);
        }
    }
}