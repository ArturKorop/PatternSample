using Common.Code;
using PatternLibrary.Patterns.State.Abstract;
using PatternLibrary.Patterns.State.Code.Common;

namespace PatternLibrary.Patterns.State.Code.States
{
    public class SoldState : BaseState
    {
        public SoldState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public override void InsertQuarter()
        {
            "Please wait, we're already giving you a gumball".P();
        }

        public override void EjectQuarter()
        {
            "Sorry, you already turned the crank".P();
        }

        public override void TurnCrank()
        {
            "Turning twice doesn't get you another gumball".P();
        }

        public override void Dispense()
        {
            GumballMachine.ReleaseBall();
            if (GumballMachine.Count > 0)
            {
                GumballMachine.SetState(GumballMachine.NoQuarterState);
            }
            else
            {
                "Oops, out of gumballs!".P();
                GumballMachine.SetState(GumballMachine.SoldOutState);
            }
        }
    }
}