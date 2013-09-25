using PatternLibrary.Patterns.Command.Abstract;
using PatternLibrary.Patterns.Command.Code.RemotingObjcets;

namespace PatternLibrary.Patterns.Command.Code.Commands
{
    public class LightOffCommand : Command<Light>
    {
        public LightOffCommand(Light target) : base(target)
        {
        }

        public override void Exequte()
        {
            Target.Off();
        }
    }
}