using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleApp2
{
    class Program
    {
       // private static readonly ILog log = LogHelper.GetLogger();
        private static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //private static readonly ILog log = LogManager.GetLogger(string.Empty);
        static void Main(string[] args)
        {
            //log.Debug("Developer: Tutorial was run");
            //log.Info("Maintenance: water pump turned on");
            //log.Warn("Maintenance: the water pump is getting hot");
            var code = "code";
            var policyId = 123456;
            var customerId = 90876;
            var metRefId = 1;

            log.Debug($"Generated url code: {code} for policy with id: {policyId},customer id: {customerId}, MetRefId: {metRefId}");

            Console.WriteLine("hello");
            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {
                log.Error($"developer: we tried to divide by zero again {ex.Message}", ex);
            }
            Console.ReadLine();
        }
    }
}
