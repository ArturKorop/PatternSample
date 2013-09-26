using System;
using Common.Code;

namespace PatternLibrary.Patterns.Command.Code.RemotingObjcets
{
    public class Stereo
    {
        private bool _isEnable;
        private bool _isCDPresent;
        private int _volume;
        private string _currentCDName;

        private int Volume
        {
            set
            {
                if (value >= 0 && value <= 20)
                {
                    _volume = value;
                    "Volume was set to {0}".P(_volume);
                }
                else
                    throw new ArgumentOutOfRangeException("value","Volume must be from 0 to 20");
            }
        }

        public void On()
        {
            if (!_isEnable)
            {
                _isEnable = true;
                "Stereo was ON".P();
            }
            else
            {
                "Stereo already was ON".P();
            }
        }
 
        public void Off()
        {
            if (_isEnable)
            {
                _isEnable = false;
                "Stereo was OFF".P();
            }
            else
            {
                "Stereo already was OFF".P();
            }
        }

        public void SetCD(string name)
        {
            if (!_isCDPresent)
            {
                _currentCDName = name;
                _isCDPresent = true;
                "CD {0} was inserted".P(_currentCDName);
            }
            else
            {
                "Error - CD {0} alredy presented in the CD deck".P(_currentCDName);
            }
        }

        public void EjectCD()
        {
            if (_isCDPresent)
            {
                _currentCDName = String.Empty;
                _isCDPresent = false;
                "CD {0} was ejected".P(_currentCDName);
            }
            else
            {
                "Error - no CD in the CD deck".P(_currentCDName);
            }
        }

        public void SetVolume(int volume)
        {
            try
            {
                Volume = volume;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ex.Message.P();
            }
        }
    }
}