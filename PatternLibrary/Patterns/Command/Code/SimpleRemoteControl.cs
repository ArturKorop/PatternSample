using PatternLibrary.Patterns.Command.Interface;

namespace PatternLibrary.Patterns.Command.Code
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.Exequte();
        }
    }
}