using PatternLibrary.Patterns.MVC.Interface;

namespace PatternLibrary.Patterns.MVC.Code.Common
{
    public class BeatController : IController
    {
        private readonly IBeatModel _beatModel;

        public BeatController(IBeatModel model)
        {
            _beatModel = model;
            _beatModel.Initialize();
        }

        public void Start()
        {
            _beatModel.On();
        }

        public void Stop()
        {
            _beatModel.Off();
        }

        public void IncreaseBPM()
        {
            _beatModel.SetBPM(_beatModel.GetBPM() + 1);
        }

        public void DecreaseBPM()
        {
            _beatModel.SetBPM(_beatModel.GetBPM() - 1);
        }

        public void SetBPM(int bpm)
        {
            _beatModel.SetBPM(bpm);
        }
    }
}