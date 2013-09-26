using PatternLibrary.Patterns.Command.Code.RemotingObjcets;

namespace PatternLibrary.Patterns.Command.Code.Commands
{
    public class CeilingFanOffCommand : Abstract.Command<CeilingFan>
    {
        private CeilingFanSpeed _prevSpeed;

        public CeilingFanOffCommand(CeilingFan target) : base(target)
        {
        }

        public override void Exequte()
        {
            _prevSpeed = Target.Speed;
            Target.Off();
        }

        public override void Undo()
        {
            SetSpeed(_prevSpeed);
        }

        private void SetSpeed(CeilingFanSpeed speed)
        {
            switch (speed)
            {
                case CeilingFanSpeed.Low:
                    Target.Low();
                    break;
                case CeilingFanSpeed.Medium:
                    Target.Medium();
                    break;
                case CeilingFanSpeed.High:
                    Target.High();
                    break;
                case CeilingFanSpeed.Off:
                    Target.Off();
                    break;
            }
        }
    }
}