using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.

            Console.WriteLine("Įveskite bet kokį sveiką skaičių: ");
            Console.WriteLine();
            int skaicius=Convert.ToInt32(Console.ReadLine());
            for (int i =1 ; i < 6; i++) 
            {
                int sandauga = skaicius * i;
                Console.WriteLine($"{skaicius} * {i} = {sandauga}");
            }
            
            // 2.
            Console.WriteLine();
            Console.WriteLine("Įveskite tris skaičių: ");
            double skaiciusPirmas = Convert.ToDouble(Console.ReadLine());
            double skaiciusAntras = Convert.ToDouble(Console.ReadLine());
            double skaiciusTrecias = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine();
            double vidurkis = (skaiciusPirmas + skaiciusAntras + skaiciusTrecias) / 3;
            Console.WriteLine($"Skaičių {skaiciusPirmas}, {skaiciusAntras}, {skaiciusTrecias} vidurkis = {vidurkis}");

            // 3.
            Console.WriteLine();
            {
                int skaicius1, skaicius2, skaicius3;

                Console.WriteLine("Įveskite tris skaičių: ");
                skaicius1 = int.Parse(Console.ReadLine());
                skaicius2 = int.Parse(Console.ReadLine());
                skaicius3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Skaičius\tKvadratu\tKūbu");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"{skaicius1}\t\t{Math.Pow(skaicius1, 2)}\t\t{Math.Pow(skaicius1, 3)}");
                Console.WriteLine($"{skaicius2}\t\t{Math.Pow(skaicius, 2)}\t\t{Math.Pow(skaicius, 3)}");
                Console.WriteLine($"{skaicius3}\t\t{Math.Pow(skaicius3, 2)}\t\t{Math.Pow(skaicius3, 3)}");

                Console.ReadLine();
            }

        }
    }
}
