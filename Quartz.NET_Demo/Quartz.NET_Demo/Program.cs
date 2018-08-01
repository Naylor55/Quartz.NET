using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.NET_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }


        /// <summary>
        /// 3.0之后版本的写法
        /// </summary>
        /// <returns></returns>
        public async Task Do()
        {
            //        NameValueCollection props = new NameValueCollection
            //{
            //    { "quartz.serializer.type", "binary" }
            //};
            //        StdSchedulerFactory factory = new StdSchedulerFactory(props);

            //        IScheduler sched = await factory.GetScheduler();
            //        await sched.Start();

            //        IJobDetail job = JobBuilder.Create<DemoJob>()
            //            .WithIdentity("myJob", "group1")
            //            .Build();

            //        ITrigger trigger = TriggerBuilder.Create()
            //            .WithIdentity("myTrigger", "group1")
            //            .StartNow()
            //            .WithSimpleSchedule(x => x
            //                .WithIntervalInSeconds(40)
            //                .RepeatForever())
            //        .Build();
            //        await sched.ScheduleJob(job, trigger);
        }

        /// <summary>
        /// 2.0
        /// </summary>
        public static void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();
            IJobDetail job = JobBuilder.Create<DemoJob>().Build();
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("IDGJob", "IDG")
                .StartNow()
                .WithSimpleSchedule(s => s.WithIntervalInSeconds(3).RepeatForever())
                .Build();
            scheduler.ScheduleJob(job, trigger);
        }

    }




}
