using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinLearning.GenericTypes
{
    internal class GenericCar
    {
        private string _make;
        private string _model;
        private int _year;
        private int _value;

        public string Make{ get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public int Value { get; set; }
         
        public GenericCar(string make, string model, int year, int value)
        {
            Make = make;
            Model = model;
            Year = year;
            Value = value;
            
        }

    }
}
