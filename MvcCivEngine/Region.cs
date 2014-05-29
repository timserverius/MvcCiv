using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcCivEngine
{
    public class Region
    {
        List<Building> buildings = new List<Building>();
        public string Name { get; set; }
        public string Description { get; set; }
        public Inventory Inventory { get; set; }

        public IEnumerable<Building> Buildings
        {
            get { return buildings;}

    }
}
