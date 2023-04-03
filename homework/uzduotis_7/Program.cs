using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 1.

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Įveskite savo vardą: ");
            string vardas=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Įveskite savo amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Jūsų vardas - {vardas}, o amžius {amzius}.");

            // 2.

            Console.WriteLine();
            Console.WriteLine("Įveskite simbolį: ");
            char simbolis=Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            
            for (int i=0; i<3; i++)
            {
                for (int j = 0; j < 3; j++)
                { 
                    Console.Write(simbolis + " ");
                }
                Console.WriteLine();
            }

            // 3.
            Console.WriteLine();
            Console.WriteLine("Įveskite skaičių: ");
            double skaicius=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(Math.Pow(skaicius,2));

            // 4.
            Console.WriteLine();
            Console.WriteLine("Įveskite tris skaičių: ");

            double skaiciusPirmas = Convert.ToDouble(Console.ReadLine());
            double skaiciusAntras = Convert.ToDouble(Console.ReadLine());
            double skaiciusTrecias = Convert.ToDouble(Console.ReadLine());
            double suma = skaiciusPirmas + skaiciusAntras + skaiciusTrecias;
            Console.WriteLine();
            Console.WriteLine($"Skaičių suma = {suma}");



        }
    }
}
