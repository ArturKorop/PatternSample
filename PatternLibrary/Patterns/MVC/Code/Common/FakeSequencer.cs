using System;
using System.Threading;
using System.Threading.Tasks;
using PatternLibrary.Patterns.MVC.Interface;

namespace PatternLibrary.Patterns.MVC.Code.Common
{
    public class FakeSequencer : ISequencer
    {
        private readonly Random _rand;
        private int _bpm;
        private int _tempo;
        private bool _isStarted;

        public event Action<int> ChangeTempo;

        public FakeSequencer() 
        {
            _rand = new Random();
            _tempo = 0;
            _bpm = 0;
        }

        public void Start()
        {
            _isStarted = true;
            Task.Factory.StartNew(() =>
                {
                    while (_isStarted)
                    {
                        _tempo = _rand.Next(_bpm);
                        NotifyListener(_tempo);
                        Thread.Sleep(1000);
                    }
                });
        }

        public void Stop()
        {
            _isStarted = false;
            _tempo = 0;
            _bpm = 0;
        }

        public void SetTempInBPM(int bpm)
        {
            _bpm = bpm;
        }

        public int GetTempo()
        {
            return _tempo;
        }

        private void NotifyListener(int tempo)
        {
            ChangeTempo(tempo);
        }
    }
}