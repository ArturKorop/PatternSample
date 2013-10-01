using Common.Code;
using PatternLibrary.Patterns.State.Code.Common;
using PatternLibrary.Patterns.State.Interface;

namespace PatternLibrary.Patterns.State
{
    [Runnable(true)]
    public class StateStarter
    {
        public static void Start()
        {
            IGumballMachine gumballMachine = new GumballMachine(3);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
        } 
    }
}