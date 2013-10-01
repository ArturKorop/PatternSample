using Common.Code;
using PatternLibrary.Patterns.State.Code.States;
using PatternLibrary.Patterns.State.Interface;

namespace PatternLibrary.Patterns.State.Code.Common
{
    public class GumballMachine : IGumballMachine
    {
        private readonly IState _noQuarterState;
        private readonly IState _soldOutState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private IState _currentState;
        private int _count;

        public int Count
        {
            get { return _count; }
        }

        public IState SoldOutState
        {
            get { return _soldOutState; }
        }

        public IState NoQuarterState
        {
            get { return _noQuarterState; }
        }

        public IState HasQuarterState
        {
            get { return _hasQuarterState; }
        }

        public IState SoldState
        {
            get { return _soldState; }
        }

        public GumballMachine(int count)
        {
            _noQuarterState = new NoQuarterState(this);
            _soldOutState = new SoldOutState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _count = count;

            if (_count > 0)
                _currentState = _noQuarterState;
        }

        public void InsertQuarter()
        {
            _currentState.InsertQuarter();
        }

        public void EjectQarter()
        {
            _currentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            _currentState.TurnCrank();
            _currentState.Dispense();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public void ReleaseBall()
        {
            "A gumball comes rolling out the slot...".P();

            if (_count != 0)
                _count--;
        }

    }
}