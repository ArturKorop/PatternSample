using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using PatternProxy;


namespace PatternProxyStarter
{
    class Program
    {
        readonly static Uri BaseAddress = new Uri("http://localhost:8080/GumballMachineService");

        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(MainService), BaseAddress))
            {
                var smb = new ServiceMetadataBehavior
                    {
                        HttpGetEnabled = true,
                        MetadataExporter = {PolicyVersion = PolicyVersion.Policy15}
                    };

                host.Description.Behaviors.Add(smb);
                host.Open();

                Console.WriteLine("The service is ready at {0}", BaseAddress);
                Console.WriteLine("Press <q> to stop the service.");
                Console.ReadKey();
               
                host.Close();
            }
        }
    }
}
