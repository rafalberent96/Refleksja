using Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Simple
{
    [Description("Metoda Result w klasie Div zwraca wynik dzielenia dwóch zmiennych. Np. x=4, y=2, x/y=2")]

    class Div : IMath
    {
        public double Result(double x, double y)
        {
            if(y!=0) return x / y;
            return 0;
        }
    }
}
