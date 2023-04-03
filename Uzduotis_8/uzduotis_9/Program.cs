using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.

            Console.WriteLine("Įveskite savo amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (amzius >= 18) Console.WriteLine("Jūs galite balsuoti."); else Console.WriteLine("Per jaunas balsuoti");

            //2.

            Console.WriteLine();
            Console.WriteLine("Įveskite savo amžių: ");
            int amzius1= Convert.ToInt32(Console.ReadLine());
            if (amzius1 < 0) Console.WriteLine("Varyk iš čia.");
            if (amzius1 > 0) Console.WriteLine("Valio.");
            if (amzius1 % 2 == 0) Console.WriteLine("Taip, skačius yra lyginis.");
            if (amzius1 % 4 == 0) Console.WriteLine("Taip, skačius dalinasi iš 46.");
            if (amzius1 > 10) Console.WriteLine("Taip, skačius yra didesnis už 10.");

            // 3.
            Console.WriteLine();
            Console.WriteLine("Įveskite du skaičius: ");
            double skaicius1= Convert.ToDouble(Console.ReadLine());
            double skaicius2= Convert.ToDouble(Console.ReadLine());
            double vidurkis = (skaicius2 + skaicius2) / 2;
            if (vidurkis >= 5) Console.WriteLine("Valio!"); else Console.WriteLine("Vidurkis mažesnis už 5.");
        }

        }
    }

