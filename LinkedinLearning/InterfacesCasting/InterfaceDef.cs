using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinLearning.InterfacesCasting
{
    internal interface InterfaceDef
    {

        static string name;

        string Name { get; set; }

        void PrintName();

    }
}
