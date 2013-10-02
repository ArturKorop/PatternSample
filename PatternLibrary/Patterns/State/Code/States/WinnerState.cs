using Common.Code;
using PatternLibrary.Patterns.State.Abstract;
using PatternLibrary.Patterns.State.Code.Common;

namespace PatternLibrary.Patterns.State.Code.States
{
    public class WinnerState : BaseState
    {
        public WinnerState(GumballMachine gumballMachine)
            : base(gumballMachine)
        {
        }

        public override void InsertQuarter()
        {
            "Sorry, wrong operation".P();
        }

        public override void EjectQuarter()
        {
            "Sorry, wrong operation".P();
        }

        public override void TurnCrank()
        {
            "Sorry, wrong operation".P();
        }

        public override void Dispense()
        {
            "You're a winner! You get two gumballs for your quarter".P();
            GumballMachine.ReleaseBall();
            if (GumballMachine.Count == 0)
            {
                GumballMachine.SetState(GumballMachine.SoldOutState);
            }
            else
            {
                GumballMachine.ReleaseBall();
                if (GumballMachine.Count > 0)
                {
                    GumballMachine.SetState(GumballMachine.NoQuarterState);
                }
                else
                {
                    "Oops, out of gumballs".P();
                    GumballMachine.SetState(GumballMachine.SoldOutState);
                }
            }
        }
    }
}