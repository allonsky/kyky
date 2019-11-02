using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сишурп1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, g;
            for (double v = 0 ; v <= 3; v++)
            {
                x += v;
                y++;
            }
            g = x / y;
            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}
