using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcCivEngine
{
    public class TechTree
    {
        //List<TechBranch> branches = new List<TechBranch>();
        Dictionary<int, TechBranch> branches = new Dictionary<int, TechBranch>();
        public IEnumerable<TechBranch> Branches
        {
            get { return branches.Values.ToList(); }
        }

        public void AddPointsToBranch(int branchId,int points)
        {
            branches[branchId].ApplyResearchPoints(points);

        }
        public void AddBranch(TechBranch branch)
        {
            branches.Add(branch.Id,branch);
        }

        public void RemoveBranch(int branchId)
        {
            TechBranch branch = branches[branchId];
            RemoveBranch(branch);
        }

        public void RemoveBranch(TechBranch branch)
        {
            branches.Remove(branch.Id);
        }

        public void UpdateBranches()
        {
            var branchList = (from b in branches.Values
                              where b.Status == TechBranchStatus.Pending
                              select b).ToList();

            foreach(TechBranch branch in branchList)
            {
                TechBranchStatus status = TechBranchStatus.Open;
                foreach(int i in branch.PrerequisiteBranchIds)
                {
                    
                    if(branches[i].Status != TechBranchStatus.Completed)
                    {
                        status = TechBranchStatus.Pending;
                        break;
                    }
                }
                if (status == TechBranchStatus.Open)
                {
                    branches[branch.Id].Open();
                }
            }
        }

    }
}
