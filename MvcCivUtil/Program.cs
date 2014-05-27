using MvcCivEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCivUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            GatherTask gt = new GatherTask();

            gt.Name = "Test";
            gt.Id = 1;
            gt.ProductionRate = 1.5;
            gt.SendTick();
            gt.SendTick();
            gt.SendTick();

            Console.WriteLine("Resources gathered = {0}",gt.GatheredAmount);
            int amount = gt.Gather();
            Console.WriteLine("Gathered {0} resourced ", amount);
            Console.WriteLine("Remaining resources gathered = {0}", gt.GatheredAmount);
            Console.ReadKey();

        }
    }
}
