using QuartzJob;
using System.ServiceProcess;

namespace TimedTask
{
    partial class TimedService : ServiceBase
    {
        public TimedService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: 在此处添加代码以启动服务。
            var _jobBase = new JobBase();
            _jobBase.ScheduleJob("", "");
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
        }
    }
}
