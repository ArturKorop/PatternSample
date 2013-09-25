using Common.Code;
using PatternLibrary.Patterns.Command.Code;
using PatternLibrary.Patterns.Command.Code.Commands;
using PatternLibrary.Patterns.Command.Code.RemotingObjcets;

namespace PatternLibrary.Patterns.Command
{
    [Runnable(true)]
    public class CommandStarter
    {
         public static void Start()
         {
             var remoteControl = new RemoteControl();
             remoteControl.P();

             var light = new Light();
             var lightOn = new LightOnCommand(light);
             var lightOff = new LightOffCommand(light);

             remoteControl.SetCommand(2, lightOn, lightOff);
             remoteControl.OnButtonPushed(2);
         }
    }
}