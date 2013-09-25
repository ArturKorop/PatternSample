using Common.Code;

namespace PatternLibrary.Patterns.Command.Code.RemotingObjcets
{
    public class Light
    {
        private bool _isOn;

        public void On()
        {
            if (!_isOn)
            {
                _isOn = true;
                "Light ON".P();
            }
            else
            {
                "Light is already ON".P();
            }
        }

        public void Off()
        {
            if (_isOn)
            {
                _isOn = false;
                "Light OFF".P();
            }
            else
            {
                "Light is already OFF".P();
            }
            
        }
    }
}