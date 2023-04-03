using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string marke = "Honda";
            string modelis = "Civic";
            int metai = 2020; 
            int rida = 10000;

            Console.WriteLine($"Automobilio {marke} {modelis} ({metai} m.) rida - {rida} km.");
        }
    }
}