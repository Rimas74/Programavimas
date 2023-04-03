using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double skaicius1 = 4;
            double skaicius2 = 5;
            double skaicius3 = 6;

            // 1.

            Console.WriteLine(skaicius1 + skaicius2);
            Console.WriteLine(skaicius1 - skaicius2);
            Console.WriteLine(skaicius1 * skaicius2);
            Console.WriteLine(skaicius1 / skaicius2);

            // 2.
            
            Console.WriteLine(skaicius2);
            Console.WriteLine(Math.Pow(skaicius2, 2));
            Console.WriteLine(Math.Pow(skaicius2, 3));


            // 3.
            Console.WriteLine(skaicius1*skaicius2*skaicius3);
        }
    }
}
