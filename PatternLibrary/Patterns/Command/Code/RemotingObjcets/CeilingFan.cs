using Common.Code;

namespace PatternLibrary.Patterns.Command.Code.RemotingObjcets
{
    public class CeilingFan
    {
        private CeilingFanSpeed _speed;
        private readonly string _name;

        public CeilingFanSpeed Speed
        {
            get { return _speed; }
        }

        public CeilingFan(string name)
        {
            _name = name;
        }

        public void Off()
        {
            _speed = CeilingFanSpeed.Off;
            "CeilingFun {0} was OFF".P(_name);
        }

        public void Low()
        {
            _speed = CeilingFanSpeed.Low;
            "CeilingFun {0} speed was set to {1}".P(_name, _speed);
        }

        public void Medium()
        {
            _speed = CeilingFanSpeed.Medium;
            "CeilingFun {0} speed was set to {1}".P(_name, _speed);
        }

        public void High()
        {
            _speed = CeilingFanSpeed.High;
            "CeilingFun {0} speed was set to {1}".P(_name, _speed);
        }
    }

    public enum CeilingFanSpeed
    {
        Off,
        Low,
        Medium,
        High
    }
}