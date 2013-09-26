using PatternLibrary.Patterns.Command.Code.RemotingObjcets;

namespace PatternLibrary.Patterns.Command.Code.Commands
{
    public class StereoOffCommand : Abstract.Command<Stereo>
    {
        public StereoOffCommand(Stereo target) : base(target)
        {
        }

        public override void Exequte()
        {
            Target.SetVolume(0);
            Target.EjectCD();
            Target.Off();
        }

        public override void Undo()
        {
            Target.On();
            Target.SetCD("Miami bluz");
            Target.SetVolume(11);
        }
    }
}