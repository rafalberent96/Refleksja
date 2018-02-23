using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    [Description("Metoda Result w klasie Mod zwraca wynik modulo dwóch zmiennych. Np. x=6, y=5, x%y=1")]
    class Mod : IMath
    {        
        public double Result(double x, double y)
        {
            return x % y;
        }
    }
}
