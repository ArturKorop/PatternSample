using System;
using Common.Code;
using PatternLibrary.Patterns.State.Abstract;
using PatternLibrary.Patterns.State.Code.Common;

namespace PatternLibrary.Patterns.State.Code.States
{
    public class HasQuarterState : BaseState
    {
        readonly Random _rand = new Random();

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
            int winner = _rand.Next(10);
            if (winner == 0 && GumballMachine.Count > 1)
            {
                GumballMachine.SetState(GumballMachine.WinnerState);
            }
            else
            {
                GumballMachine.SetState(GumballMachine.SoldState);
            }
        }

        public override void Dispense()
        {
            "No gumball dispensed".P();
        }
    }
}