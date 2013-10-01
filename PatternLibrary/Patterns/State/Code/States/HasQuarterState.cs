using Common.Code;
using PatternLibrary.Patterns.State.Abstract;
using PatternLibrary.Patterns.State.Code.Common;

namespace PatternLibrary.Patterns.State.Code.States
{
    public class HasQuarterState : BaseState
    {
        public HasQuarterState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public override void InsertQuarter()
        {
            "You can't insert another quarter".P();
        }

        public override void EjectQuarter()
        {
            "Quarter returned".P();
            GumballMachine.SetState(GumballMachine.NoQuarterState);
        }

        public override void TurnCrank()
        {
            "You turned...".P();
            GumballMachine.SetState(GumballMachine.SoldState);
        }

        public override void Dispense()
        {
            "No gumball dispensed".P();
        }
    }
}