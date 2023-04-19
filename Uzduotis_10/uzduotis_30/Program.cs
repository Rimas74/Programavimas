using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leiskite vartotojui įvesti du sveikuosius skaičius į programą.  
             * Sukurkite ir panaudokite šiuos metodus:
                Suma;
                Skirtumas;
                Sandauga;
                Dalmuo;
                */
            Console.WriteLine("įveskit pirmą sveiką skaičių:");
            int skaiciusPirmas = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("įveskit antrą sveiką skaičių:");                      
            int skaiciusAntras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{skaiciusPirmas} + {skaiciusAntras} = {Suma(skaiciusPirmas, skaiciusAntras)}");
            Console.WriteLine($"{skaiciusPirmas} - {skaiciusAntras} = {Skirtumas(skaiciusPirmas, skaiciusAntras)}");
            Console.WriteLine($"{skaiciusPirmas} * {skaiciusAntras} = {Sandauga(skaiciusPirmas, skaiciusAntras)}");
            Console.WriteLine($"{skaiciusPirmas} / {skaiciusAntras} = {Dalyba(skaiciusPirmas, skaiciusAntras):N2}");

        }

        private static double Dalyba(int skaiciusPirmas, int skaiciusAntras)
        {
            return (double )skaiciusPirmas / skaiciusAntras;
        }

        private static object Sandauga(int skaiciusPirmas, int skaiciusAntras)
        {
            return skaiciusPirmas * skaiciusAntras;
        }

        private static int Skirtumas(int skaiciusPirmas, int skaiciusAntras)
        {
            return skaiciusPirmas - skaiciusAntras;
        }

        private static int Suma(int skaiciusPirmas, int skaiciusAntras)
        {
            return skaiciusPirmas + skaiciusAntras;
        }



    }
}
