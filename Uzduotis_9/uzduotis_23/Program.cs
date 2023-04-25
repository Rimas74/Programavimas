using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 Susikurkite kintamąjį, kuris pasakytų kiek automobilis vidutiniškai sunaudoja  degalų 100 – ui km. Susikurkite masyvą, kuriame saugotumėte skirtingose
kelionėse nuvažiuotų kilometrų rodmenis. Raskite:
1. trumpiausią kelionę;
2. ilgiausią kelionę;
3. kiek kuro sąnaudų sunaudojo automobilis (skaičiavimui reikės rasti visus  nuvažiuotus km).
*/
namespace uzduotis_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] distances = new int[10];
            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = random.Next(0, 500);
            }
            for (int i = 0;i < distances.Length; i++)
            {
                Console.WriteLine($" {i+1} atstumo nuvažiuoti {distances[i]} km");
            }

            
            Console.WriteLine($"trumpiausia kelione - {distances.Min()} km");
            Console.WriteLine($"ilgiausia kelione - {distances.Max()} km");
            Console.WriteLine($"Bendra nuvaaziuotu kilometru suma - {distances.Sum()}.");

            Console.WriteLine("Iveskite kiek bendrai sunaudotojote kuro visu 10 kelioniu metu ltr: ");
            //string sunaudotasKurasStr = (Console.ReadLine());
            float sunaudotasKuras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"automobilis vidutiniškai sunaudoja  litrų degalų 100 – ui km: {sunaudotasKuras *100 / distances.Sum() :F2}");

        }
    }
}
