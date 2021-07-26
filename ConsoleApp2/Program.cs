﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleApp2
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            //log.Debug("Developer: Tutorial was run");
            //log.Info("Maintenance: water pump turned on");
            //log.Warn("Maintenance: the water pump is getting hot");

            

            Console.WriteLine("hello");
            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {
                log.Error("developer: we tried to divide by zero again", ex);
            }
            Console.ReadLine();
        }
    }
}
