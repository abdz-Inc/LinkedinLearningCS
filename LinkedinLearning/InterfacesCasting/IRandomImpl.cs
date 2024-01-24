using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinLearning.InterfacesCasting
{
    internal class IRandomImpl : IRandomisable
    {
        public double GetRandomNum(int upperbound)
        {
            Random rd = new Random();
            double rnum = rd.NextDouble() * upperbound;
            
            return rnum;
        }

    }
}
