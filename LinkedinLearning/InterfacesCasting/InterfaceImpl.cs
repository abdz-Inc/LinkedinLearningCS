using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinLearning.InterfacesCasting
{
    internal class InterfaceImpl : InterfaceDef
    {

        public string Name
        {
            get; set;
        }

        public InterfaceImpl(string name)
        {
            Name = name;
        }

        public void PrintName()
        {
            Console.WriteLine("hi " + Name);
        }
    }
}
