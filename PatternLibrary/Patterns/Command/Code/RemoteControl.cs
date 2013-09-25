using System;
using System.Text;
using PatternLibrary.Patterns.Command.Code.Commands;
using PatternLibrary.Patterns.Command.Interface;

namespace PatternLibrary.Patterns.Command.Code
{
    public class RemoteControl
    {
        private const int ButtonCount = 7;
        private ICommand[] _onCommands = new ICommand[ButtonCount];
        private ICommand[] _offCommands = new ICommand[ButtonCount];

        public RemoteControl()
        {
            for (int i = 0; i < ButtonCount; i++)
            {
                _onCommands[i] = new NoCommand();
                _offCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            if(slot >= ButtonCount)
                throw new ArgumentOutOfRangeException(String.Format("SetCommand: Incoming count {0} > Max count {1}", slot, ButtonCount));

            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonPushed(int slot)
        {
            if (slot >= ButtonCount)
                throw new ArgumentOutOfRangeException(String.Format("OnButtonPushed: Incoming count {0} > Max count {1}", slot, ButtonCount));
        
            _onCommands[slot].Exequte();
        }

        public void OffButtonPushed(int slot)
        {
            if (slot >= ButtonCount)
                throw new ArgumentOutOfRangeException(String.Format("OffButtonPushed: Incoming count {0} > Max count {1}", slot, ButtonCount));

            _offCommands[slot].Exequte();
        }

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine("-------- Remote Control --------");
            for (int i = 0; i < ButtonCount; i++)
            {
                text.AppendFormat("[Slot {0}]: On {1}, Off {2} \n", i, _onCommands[i].GetType().Name,
                                  _offCommands[i].GetType().Name);
            }

            return text.ToString();
        }
    }
}