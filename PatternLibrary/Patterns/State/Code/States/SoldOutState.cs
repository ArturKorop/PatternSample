using Common.Code;
using PatternLibrary.Patterns.State.Abstract;
using PatternLibrary.Patterns.State.Code.Common;

namespace PatternLibrary.Patterns.State.Code.States
{
    public class SoldOutState : BaseState
    {
        public SoldOutState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public override void InsertQuarter()
        {
            "Sorry, gumballs ended".P();
        }

        public override void EjectQuarter()
        {
            "Sorry, gumballs ended".P();
        }

        public override void TurnCrank()
        {
            "Sorry, gumballs ended".P();
        }

        public override void Dispense()
        {
            "Sorry, gumballs ended".P();
        }

        public override void AddGumballs(int count)
        {
            base.AddGumballs(count);
            GumballMachine.SetState(GumballMachine.NoQuarterState);
        }
    }
}