using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsvestiTeksta("Sveikas pasauli!");

            Console.ReadKey();
        }

        static void IsvestiTeksta(string tekstas)
        {
            Console.WriteLine(tekstas);
        }
    }
}
