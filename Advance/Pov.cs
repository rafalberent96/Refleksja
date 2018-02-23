using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    [Description("Metoda Result w klasie Pow zwraca wynik potęgowania dwóch zmiennych. Np. x=5, y=6, x^y=15625")]

    class Pov : IMath
    {
        public double Result(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
