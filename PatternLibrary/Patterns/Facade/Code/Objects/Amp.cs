using Common.Code;

namespace PatternLibrary.Patterns.Facade.Code.Objects
{
    public class Amp
    {
        public void On()
        {
            "Amp ON".P();
        }

        public void Off()
        {
            "Amp OFF".P();
        }

        public void SetDvd(string dvdName)
        {
            "Insert DVD {0}".P(dvdName);
        }

        public void SurroudSoundOn()
        {
            "Surround sound ON".P();
        }

        public void SetVolume(int level)
        {
            "Volume level set to {0}".P(level);
        }
    }
}