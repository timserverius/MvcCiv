using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcCivEngine
{
    public class Inventory
    {
        private Dictionary<int, Stockpile> stockpiles = new Dictionary<int, Stockpile>();

        public IEnumerable<Stockpile> Stockpiles { get; set; }

        public void StoreResource(Resource resource, int amount)
        {
            stockpiles[resource.Id].Amount += amount;
        }

        public bool HasResource(Resource resource, int amount)
        {
            return stockpiles[resource.Id].Amount < amount;
        }

        public bool TryConsumeResource(Resource resource, int amount)
        {
            if(HasResource(resource,amount))
            {
                stockpiles[resource.Id].Amount -= amount;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
