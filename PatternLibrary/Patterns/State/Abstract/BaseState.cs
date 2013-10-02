using Common.Code;
using PatternLibrary.Patterns.State.Code.Common;
using PatternLibrary.Patterns.State.Interface;

namespace PatternLibrary.Patterns.State.Abstract
{
    public abstract class BaseState : IState
    {
        protected GumballMachine GumballMachine;

        protected BaseState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public abstract void InsertQuarter();

        public abstract void EjectQuarter();

        public abstract void TurnCrank();

        public abstract void Dispense();

        public virtual void AddGumballs(int count)
        {
            "Added {0} gumballs".P(count);
            GumballMachine.AddGumballsConcrete(count);
        }
    }
}