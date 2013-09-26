using PatternLibrary.Patterns.Command.Code.RemotingObjcets;

namespace PatternLibrary.Patterns.Command.Code.Commands
{
    public class StereoOnCommand : Abstract.Command<Stereo>
    {
        public StereoOnCommand(Stereo target) : base(target)
        {
        }

        public override void Exequte()
        {
            Target.On();
            Target.SetCD("Miami bluz");
            Target.SetVolume(11);
        }

        public override void Undo()
        {
            Target.SetVolume(0);
            Target.EjectCD();
            Target.Off();
        }
    }
}