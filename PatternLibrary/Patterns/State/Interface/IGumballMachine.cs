namespace PatternLibrary.Patterns.State.Interface
{
    public interface IGumballMachine
    {
        void InsertQuarter();
        void EjectQarter();
        void TurnCrank();
        void AddGumballs(int count);
    }
}