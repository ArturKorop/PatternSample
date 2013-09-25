using Common.Code;
using PatternLibrary.Patterns.Command.Interface;

namespace PatternLibrary.Patterns.Command.Code.Commands
{
    public class NoCommand : ICommand

    {
        public void Exequte()
        {
            "No command".P();
        }
    }
}