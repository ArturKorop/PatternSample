using Common.Code;
using PatternLibrary.Patterns.Command.Code;
using PatternLibrary.Patterns.Command.Code.Commands;
using PatternLibrary.Patterns.Command.Code.RemotingObjcets;
using PatternLibrary.Patterns.Command.Interface;

namespace PatternLibrary.Patterns.Command
{
    [Runnable(true)]
    public class CommandStarter
    {
        public static void Start()
        {
            var remoteControl = new RemoteControl();

            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);
            var stereo = new Stereo();
            var stereoOn = new StereoOnCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);
            var ceililngFan = new CeilingFan("Kitchen room");
            var ceililngFanLowOn = new CeilingFanOnCommand(ceililngFan, CeilingFanSpeed.Low);
            var ceililngFanMediumOn = new CeilingFanOnCommand(ceililngFan, CeilingFanSpeed.Medium);
            var ceililngFanHighOn = new CeilingFanOnCommand(ceililngFan, CeilingFanSpeed.High);
            var ceililngFanOff = new CeilingFanOffCommand(ceililngFan);
            var partyOn = new MacroCommand(new ICommand[] {lightOn, stereoOn});
            var partyOff = new MacroCommand(new ICommand[] { lightOff, stereoOff });

            remoteControl.SetCommand(2, lightOn, lightOff);
            remoteControl.SetCommand(3, stereoOn, stereoOff);
            remoteControl.SetCommand(4, ceililngFanLowOn, ceililngFanOff);
            remoteControl.SetCommand(5, ceililngFanMediumOn, ceililngFanOff);
            remoteControl.SetCommand(6, ceililngFanHighOn, ceililngFanOff);
            remoteControl.SetCommand(1, partyOn, partyOff);
            remoteControl.P();
            RemoteControlPressButtons(remoteControl);
        }

        private static void RemoteControlPressButtons(RemoteControl remoteControl)
        {
            remoteControl.OnButtonPushed(2);
            remoteControl.UndoButtonPushed();
            remoteControl.OnButtonPushed(3);
            remoteControl.OnButtonPushed(3);
            remoteControl.OffButtonPushed(3);
            remoteControl.UndoButtonPushed();
            remoteControl.UndoButtonPushed();
            remoteControl.UndoButtonPushed();
            remoteControl.UndoButtonPushed();
            remoteControl.UndoButtonPushed();
            "-----------------------------".P();
            remoteControl.OnButtonPushed(4);
            remoteControl.OnButtonPushed(5);
            remoteControl.OnButtonPushed(6);
            remoteControl.OffButtonPushed(4);
            remoteControl.UndoButtonPushed();
            remoteControl.UndoButtonPushed();
            remoteControl.UndoButtonPushed();
            "-----------------------------".P();
            remoteControl.OnButtonPushed(1);
            remoteControl.OffButtonPushed(1);
        }
    }
}