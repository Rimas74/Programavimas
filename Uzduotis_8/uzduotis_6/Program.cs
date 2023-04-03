using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5.

            int skaicius = 5;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(skaicius + " x " + i + " = " + (skaicius * i));
            }

            // 6.

            int skaicius1 = 456;
            int skaicius2 = skaicius1;
            int sandauga = 1;

            while (skaicius2 > 0)
            {
                int liekana = skaicius2 % 10;
                sandauga *= liekana;
                skaicius2 /= 10;
            }
            Console.WriteLine($"skaičiaus {skaicius1} visų skaitmenų sandauga lygi {sandauga}.");

        }
    }
}