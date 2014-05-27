using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcCivEngine
{
    public enum TechBranchStatus
    {
        Pending,
        Open,
        Completed
    }
    public class TechBranch
    {
        List<int> prerequisiteBranchIds = new List<int>();
        double researchPointsNeeded = 0;
        double modifier = 1;
        private TechBranchStatus status = TechBranchStatus.Pending;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<int> PrerequisiteBranchIds
        {
            get
            {
                return prerequisiteBranchIds;
            }            
        }

        public void AddPrerequisiteBranchIds(int[] idList)
        {
            foreach(int id in idList)
            {
                prerequisiteBranchIds.Add(id);
            }
        }

        public double ResearchPointsNeeded
        {
            get { return researchPointsNeeded; }
            set { researchPointsNeeded = value; }
        }


        public void ApplyResearchPoints(int rp)
        {
            researchPointsNeeded =- (rp * modifier);
            if(researchPointsNeeded<0)
            {
                researchPointsNeeded = 0;
                status = TechBranchStatus.Completed;
            }
        }


        public void Open()
        {
            status = TechBranchStatus.Open;
        }



        /// <summary>
        /// Modifier can be applied based on conditions of the game.
        /// For example, a University building could increase the rate of research for all technology branches.
        /// Another building could increate the rate of reserch for one technology branch.
        /// 
        /// It may be better to keep a list of modifiers rather than just a single value. Food for thought.
        /// </summary>
        public double Modifier
        {
            get { return modifier; }
            set { modifier = value; }
        }

        public TechBranchStatus Status
        {
            get { return status; }
        }

    }
}
