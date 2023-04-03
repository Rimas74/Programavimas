using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.

            Console.WriteLine("Įveskite tris sveikus skaičius: ");
            int skaicius1 = int.Parse(Console.ReadLine());
            int skaicius2 = int.Parse(Console.ReadLine());
            int skaicius3 = int.Parse(Console.ReadLine());

            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("Primas skaičius didesnis už antrą.");
            }
            else if (skaicius2 > skaicius3)
            {
                Console.WriteLine("Antras skaičius didesnis už trečią.");
            }
            else if (skaicius3 > skaicius1)
            {
                Console.WriteLine("Trečias skaičius didesnis už pirmą.");
            }
            else if (skaicius1 == skaicius2)
            {
                Console.WriteLine("Pirmi du skaičiai lygūs.");
            }

        }
    }
}
