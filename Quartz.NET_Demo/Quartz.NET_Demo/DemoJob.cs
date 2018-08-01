using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.NET_Demo
{
    public class DemoJob : IJob
    {
        /// <summary>
        /// 3.0之前版本写法
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        //public async Task Execute(IJobExecutionContext context)
        //{
        //    await Console.Out.WriteLineAsync("DemoJob is executing.");
        //}




        //2.0
        void IJob.Execute(IJobExecutionContext context)
        {
            Console.Out.WriteLineAsync("DemoJob is executing.");
        }
    }
}
