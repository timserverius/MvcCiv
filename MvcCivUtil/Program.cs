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
            TechTreeDemo();

        }

        private static void GatherTaskDemo1()
        {
            GatherTask gt = new GatherTask();

            gt.Name = "Test";
            gt.Id = 1;
            gt.ProductionRate = 1.5;
            gt.SendTick();
            gt.SendTick();
            gt.SendTick();

            Console.WriteLine("Resources gathered = {0}", gt.GatheredAmount);
            int amount = gt.Gather();
            Console.WriteLine("Gathered {0} resourced ", amount);
            Console.WriteLine("Remaining resources gathered = {0}", gt.GatheredAmount);
            Console.ReadKey();
        }

        private static void TechTreeDemo()
        {
            TechTree tree = new TechTree();

            TechBranch tb = new TechBranch();
            tb.Name = "A";
            tb.Id = 1;
            tb.ResearchPointsNeeded = 5;
            tb.Open();
            
            tree.AddBranch(tb);

            tb = new TechBranch();
            tb.Name = "B";
            tb.Id = 2;
            tb.AddPrerequisiteBranchIds(new int[]{1});
            tree.AddBranch(tb);

            tree.UpdateBranches();

            Console.WriteLine("Tech branch B status = {0}", tree.Branches.Where(b=>b.Id == 2).First().Status);


            tree.AddPointsToBranch(1, 6);
            tree.UpdateBranches();
            Console.WriteLine("Tech branch B status = {0}", tree.Branches.Where(b => b.Id == 2).First().Status);
            Console.ReadKey();



        }
    }
}
