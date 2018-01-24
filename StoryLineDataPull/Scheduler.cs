using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace StoryLineDataPull
{
    public partial class Scheduler : ServiceBase
    {
        private Timer timer;
        public Scheduler()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer = new Timer();
            timer.Interval = 30000;
            timer.Elapsed += new ElapsedEventHandler(this.timer_Tick);
            timer.Enabled = true;
            var dataPullManager = new DataPullManager();
            dataPullManager.Log("Service Started successfully");
        }
        private void timer_Tick(object sender, ElapsedEventArgs e)
        {
            var dataPullManager = new DataPullManager();
            dataPullManager.Log("Some job has been completed successfully.");
        }

        protected override void OnStop()
        {
            timer.Enabled = false;
            var dataPullManager = new DataPullManager();
            dataPullManager.Log("Service stopped||");
        }
    }
}
