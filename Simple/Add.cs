using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Simple
{
    [Description("Metoda Result w klasie Add zwraca wynik dodawania dwóch zmiennych. Np. x=5, y=6, x+y=11")]
    class Add : IMath
    {
        public double Result(double x, double y)
        {
            return x + y;
        }
    }
}
