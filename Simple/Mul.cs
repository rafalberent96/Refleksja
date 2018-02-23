using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Simple
{
    [Description("Metoda Result w klasie Mul zwraca wynik mnożenia dwóch zmiennych. Np. x=5, y=6, x*y=30")]

    class Mul : IMath
    {
        public double Result(double x, double y)
        {
            return x * y;
        }
    }
}
