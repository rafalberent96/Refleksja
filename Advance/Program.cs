using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = 6;
            IMath m = new Mod();
            Console.WriteLine(m.Result(x, y));
            m = new Pov();
            Console.WriteLine(m.Result(x, y));
            Console.ReadKey();


        }
    }
}
