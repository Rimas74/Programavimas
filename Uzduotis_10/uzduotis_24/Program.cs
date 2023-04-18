using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Paklausti vartotojo, kiek duomenų nori įvesti į masyvą  Pagal tai sukursime tokio dydžio masyvą
Iš konsolės įvesti duomenis į masyvą
Surasti 2 sumas:
Suma1 – kai masyvo elementas yra lyginis skaičius  
Suma2 – kai masyvo indeksas nėra lyginis skaičius
*/
namespace uzduotis_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite norimų elementų skaičių: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] masyvas = new int[n];

            Console.WriteLine($"Įveskite {n} elementus į masyvą: ");
            for (int i = 0; i < n; i++)
            {
                masyvas[i] = Convert.ToInt32(Console.ReadLine());
            }

            int Suma1 = 0;
            int Suma2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (masyvas[i] % 2 == 0)
                {
                    Suma1 += masyvas[i];
                    Console.WriteLine($"Masyvo elementas {masyvas[i]}");
                }
                if (i % 2 != 0)
                {
                    Suma2 += masyvas[i];
                    Console.WriteLine($"Masyvo indeksas {i}");
                }
            }

            Console.WriteLine($"Suma1 (lyginiai elementai) = {Suma1}");
            Console.WriteLine($"Suma2 (nelyginiai indeksai) = {Suma2}");
        }
    }
}
