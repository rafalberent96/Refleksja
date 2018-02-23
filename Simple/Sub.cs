using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Simple
{
    [Description("Metoda Result w klasie Sub zwraca wynik odejmowania dwóch zmiennych. Np. x=5, y=6, x-y=-1")]

    class Sub : IMath
    {
        public double Result(double x, double y)
        {
            return x - y;
        }
    }
}
