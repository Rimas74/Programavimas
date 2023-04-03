using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.

            Console.WriteLine("Įveskite egzamino rezultatą: ");
            double rezultatas = int.Parse(Console.ReadLine());
            if (rezultatas >= 8 && rezultatas <= 10) Console.WriteLine("Rezultatas tarp 8 ir 10.");
            else if (rezultatas >= 5 && rezultatas < 8) Console.WriteLine("Rezultatas tarp 8 ir 5.");
            else Console.WriteLine("Rezultatas mazesnis už 5");
        }
    }
}
