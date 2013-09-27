using PatternLibrary.Patterns.Facade.Code.Objects;

namespace PatternLibrary.Patterns.Facade.Code.Facade
{
    public class HomeTheaterFacade
    {
        private readonly Amp _amp;
        private readonly Popper _popper;
        private readonly Screen _screen;

        public HomeTheaterFacade(Amp amp, Popper popper, Screen screen)
        {
            _amp = amp;
            _popper = popper;
            _screen = screen;
        }

        public void On(string movie)
        {
            _popper.On();
            _screen.Down();
            _amp.On();
            _amp.SetDvd(movie);
            _amp.SetVolume(10);
            _amp.SurroudSoundOn();
        }

        public void Off()
        {
            _popper.Off();
            _screen.Up();
            _amp.Off();
        }
    }
}