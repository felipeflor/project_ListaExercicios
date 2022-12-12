using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Conversor
    {
        public double Celsius { get; set; }
        public double Fahrenheit { get; set; }
        public virtual double FpC()
        {
            Celsius = (Fahrenheit - 32) / 1.8;
            return Celsius;
        }

        public virtual double CpF()
        {
            Fahrenheit = (Celsius * 1.8) + 32;
            return Fahrenheit;
        }
    }
}
