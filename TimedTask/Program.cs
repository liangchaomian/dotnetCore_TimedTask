using System.ServiceProcess;

namespace TimedTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase[] services = new ServiceBase[] { new TimedService() };
            ServiceBase.Run(services);
        }
    }
}
