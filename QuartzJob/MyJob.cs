using Quartz;
using System.Threading.Tasks;

namespace QuartzJob
{
    public class MyJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() =>
            {
                //do something
            });
        }
    }
}
