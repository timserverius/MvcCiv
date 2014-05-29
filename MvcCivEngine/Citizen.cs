using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcCivEngine
{
    public class Citizen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Profession Profession { get; set; }
        public ICivTask ActiveTask { get; set; }
    }
}
