using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Liepkite vartotojui įvesti teigiamą skaičių. Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0. Pvz.: 5 4 3 2 1. Kiekvieną kartą išvesti skirtingose eilutėse.
2. Liepkite vartotojui įvesti neigiamą skaičių. Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0, taip pat išvesti 0. Pvz.: -4 -3 -2 -1 0.
Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.
3. Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius. Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai, išvedant kartu ir atliekamus veiksmus. Pvz.:
5 + 4 = 9
5 - 4 = 1
…
Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.

 */
namespace uzduotis_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Console.WriteLine("įvesti teigiamą skaičių: ");
            var skaicius1=Convert.ToInt32(Console.ReadLine());
            while(skaicius1 > 0) 
            {
                Console.WriteLine(skaicius1--);
            }
            // 2.
            Console.WriteLine("įvesti neigiamą skaičių: ");
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            while (skaicius2 <= 0)
            {
                Console.Write((skaicius2++) +" ");
            }

            // 3.
            string veiksmas = "t";

            while (veiksmas == "t")
            {
                Console.WriteLine("įveskite du skaičius: ");
                Console.WriteLine();
                int skaicius3 = Convert.ToInt32(Console.ReadLine());
                int skaicius4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{skaicius3} + {skaicius4} = {skaicius3 + skaicius4} \r\n");
                Console.WriteLine($"{skaicius3} - {skaicius4} = {skaicius3 - skaicius4} \r\n");
                Console.WriteLine($"{skaicius3} * {skaicius4} = {skaicius3 * skaicius4} \r\n");
                Console.WriteLine($"{skaicius3} / {skaicius4} = {skaicius3 / skaicius4} \r\n");
                Console.WriteLine();
                Console.WriteLine("norite tęsti, spauskite t, norite užbaigti spauskite bet kokį kitą simbolį");
                veiksmas =Console.ReadLine();
            }
        }
    }
}
