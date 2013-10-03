using Common.Code;
using PatternLibrary.Patterns.State.Code.Common;
using PatternLibrary.Patterns.State.Interface;

namespace PatternLibrary.Patterns.State
{
    [Runnable]
    public class StateStarter
    {
        public static void Start()
        {
            IGumballMachine gumballMachine = new GumballMachine(20, "TestGumballMachine");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQarter();
            gumballMachine.TurnCrank();

            for (int i = 0; i < 30; i++)
            {
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
                if (i == 25)
                    gumballMachine.AddGumballs(10);
            }
        } 
    }
}