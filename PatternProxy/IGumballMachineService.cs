using System.ServiceModel;

namespace PatternProxy
{
    [ServiceContract]
    public interface IGumballMachineService
    {
        [OperationContract]
        string GetStatus();

        [OperationContract]
        void GetGumball();
    }
}
