using PatternLibrary.Patterns.Command.Interface;

namespace PatternLibrary.Patterns.Command.Code.Commands
{
    public class MacroCommand : Abstract.Command<ICommand[]>
    {
        public MacroCommand(ICommand[] target) : base(target)
        {
        }

        public override void Exequte()
        {
            foreach (var command in Target)
            {
                command.Exequte();
            }
        }

        public override void Undo()
        {
            foreach (var command in Target)
            {
                command.Undo();
            }
        }
    }
}