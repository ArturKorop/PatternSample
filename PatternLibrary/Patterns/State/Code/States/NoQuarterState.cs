using Common.Code;
using PatternLibrary.Patterns.State.Abstract;
using PatternLibrary.Patterns.State.Code.Common;

namespace PatternLibrary.Patterns.State.Code.States
{
    public class NoQuarterState : BaseState
    {
        public NoQuarterState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public override void InsertQuarter()
        {
            "You inserted a quarter".P();
            GumballMachine.SetState(GumballMachine.HasQuarterState);
        }

        public override void EjectQuarter()
        {
            "You haven't inserted a quarter".P();
        }

        public override void TurnCrank()
        {
            "You turned, but there's no quarter".P();
        }

        public override void Dispense()
        {
            "You need to pay first".P();
        }
    }
}