using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil
{
    internal class Car
    {
        public string Model { get; }
        public int Year { get; }
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }

    }
}
