using Quartz;
using Quartz.Impl;
using System.Threading.Tasks;

namespace QuartzJob
{
    public class JobBase
    {
        private readonly ISchedulerFactory _schedulerFactory = new StdSchedulerFactory();
        private IScheduler _scheduler;

        /// <summary>
        /// 执行定时任务
        /// </summary>
        /// <param name="name">任务名称</param>
        /// <param name="cron">cron</param>
        /// <returns></returns>
        public async Task ScheduleJob(string name,  string cron)
        {
            //1、通过调度工厂获得调度器
            _scheduler = await _schedulerFactory.GetScheduler();
            //2、开启调度器
            await _scheduler.Start();
            //3、创建一个触发器
            var trigger = TriggerBuilder.Create()
                            .WithCronSchedule(cron)
                            .Build();
            //4、创建任务
            var jobDetail = JobBuilder.Create<MyJob>()
                            .WithIdentity(name, "group")
                            .Build();
            //5、将触发器和任务器绑定到调度器中
            await _scheduler.ScheduleJob(jobDetail, trigger);
        }
    }
}
