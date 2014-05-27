using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcCivEngine
{
    public class GatherTask:ICivTask
    {
        string name;
        private int id;
        private double productionRate;
        private double gatheredAmount;

        public GatherTask()
        {
            productionRate = 1;
            gatheredAmount = 0;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public double ProductionRate
        {
            get
            {
                return productionRate;
            }
            set
            {
                productionRate = value;
            }
        }

        public void Start()
        {
            gatheredAmount = 0;
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public int Gather()
        {
            int result = (int)gatheredAmount;
            gatheredAmount = gatheredAmount - result;
            return result;
        }

        public double GatheredAmount
        {
            get { return gatheredAmount; }
        }

        public void SendTick()
        {
            gatheredAmount += productionRate;
        }
    }
}
