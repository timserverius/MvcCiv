using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcCivEngine
{
    public interface ICivTask
    {
        string Name { get; set; }
        int Id { get; set; }
        double ProductionRate { get; set; }
        void Start();
        void Stop();
        void SendTick();
    }
}
