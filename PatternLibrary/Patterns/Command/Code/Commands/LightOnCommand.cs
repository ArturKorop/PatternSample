using PatternLibrary.Patterns.Command.Abstract;
using PatternLibrary.Patterns.Command.Code.RemotingObjcets;
using PatternLibrary.Patterns.Command.Interface;

namespace PatternLibrary.Patterns.Command.Code.Commands
{
    public class LightOnCommand : Command<Light>
    {
        public LightOnCommand(Light target) : base(target)
        {
        }

        public override void Exequte()
        {
            Target.On();
        }

        public override void Undo()
        {
            Target.Off();
        }
    }
}