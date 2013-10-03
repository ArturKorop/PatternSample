using System.ServiceModel;
using Common.Code;
using PatternLibrary.GumballMachineService;

namespace PatternLibrary.Patterns.Proxy.Code
{
    public class GumballMonitor
    {
        private readonly GumballMachineServiceClient _client;

        public GumballMonitor()
        {
            _client = new GumballMachineServiceClient(new BasicHttpBinding(),
                                                      new EndpointAddress(
                                                          "http://localhost:8080/GumballMachineService"));
            _client.Open();
        }

        public void PrintStatus()
        {
            _client.GetStatus().P();
        }

        public void GetGumball()
        {
            _client.GetGumball();
        }
    }
}