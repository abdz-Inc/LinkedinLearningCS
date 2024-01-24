using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinLearning.DelegatesEventsLambdas
{
    public class ShippingZones
    {
        private int _zonepercent;
        private int _risk;
        private bool _highrisk;

        public int Zonepercent
        {
            get; set;
        }

        public int Risk
        {
            get => _risk;
            set => _risk = value;

        }

        public bool Highrisk
        {
            get;
            set;
        }

        public ShippingZones(int zone, bool highrisk = false, int risk = 0)
        {
            Zonepercent = zone;
            Risk = risk;
            Highrisk = highrisk;
        }

        public float shippingcost(int cost)
        {
            return Highrisk ? Risk : 0 + cost * Zonepercent / 100;
        }
    }
}
