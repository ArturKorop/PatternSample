using System;
using Common.Code;
using PatternLibrary.Patterns.State.Code.States;
using PatternLibrary.Patterns.State.Interface;

namespace PatternLibrary.Patterns.State.Code.Common
{
    public class GumballMachine : IGumballMachine
    {
        #region Private property

        private readonly IState _noQuarterState;
        private readonly IState _soldOutState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _winnerState;
        private IState _currentState;
        private int _count;
        private string _location;

        #endregion

        #region Public property

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

        public IState WinnerState
        {
            get { return _winnerState; }
        } 

        #endregion

        public GumballMachine(int count, string location)
        {
            _noQuarterState = new NoQuarterState(this);
            _soldOutState = new SoldOutState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);
            _count = count;
            _location = location;

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

        public void AddGumballs(int count)
        {
            _currentState.AddGumballs(count);
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

        public void AddGumballsConcrete(int count)
        {
            _count += count;
        }

        public string GetStatus()
        {
            return String.Format("Gumball Machine from {0}, have {1} gumballs", _location, _count);
        }
    }
}