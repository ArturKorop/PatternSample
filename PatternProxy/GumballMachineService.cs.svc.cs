using System.ServiceModel;
using Common.Code;
using Common.Code.Configuration;
using Common.Interfaces;
using Microsoft.Practices.Unity;
using PatternLibrary.Patterns.State.Code.Common;

namespace PatternProxy
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MainService : IGumballMachineService
    {
        private readonly GumballMachine _gumballMachine;

        public MainService()
        {
            DIServiceLocator.Current.RegisterInstance(typeof(ITextProvider), new ConsoleTextProvider());
            Support.Configure();
            _gumballMachine = new GumballMachine(5, "TestGumballMachine");
            "GumballMachine was created".P();
        }

        public string GetStatus()
        {
            return _gumballMachine.GetStatus();
        }

        public void GetGumball()
        {
            _gumballMachine.Count.P();
            _gumballMachine.GetStatus().P();
            _gumballMachine.InsertQuarter();
            _gumballMachine.TurnCrank();
            _gumballMachine.Count.P();
            _gumballMachine.GetStatus().P();
        }
    }
}
