using PatternLibrary.Patterns.Command.Interface;

namespace PatternLibrary.Patterns.Command.Code.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Exequte()
        {
            _light.On();
        }
    }
}