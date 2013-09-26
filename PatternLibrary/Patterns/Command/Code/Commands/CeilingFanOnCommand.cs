using PatternLibrary.Patterns.Command.Code.RemotingObjcets;

namespace PatternLibrary.Patterns.Command.Code.Commands
{
    public class CeilingFanOnCommand : Abstract.Command<CeilingFan>
    {
        private readonly CeilingFanSpeed _currentSpeed;
        private CeilingFanSpeed _prevSpeed;

        public CeilingFanOnCommand(CeilingFan target, CeilingFanSpeed speed)
            : base(target)
        {
            _currentSpeed = speed;
        }

        public override void Exequte()
        {
            _prevSpeed = Target.Speed;
            SetSpeed(_currentSpeed);
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