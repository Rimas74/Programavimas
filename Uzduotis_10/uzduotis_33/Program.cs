using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Įvesti du skaičius iš konsolės
                1, Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: 
                    sudėtis, atimtis,  
                    kėlimas 4 laipsniu sudėjus abu skaičius, 
                    kvadratinė šaknis sudėjus abu skaičius.
                2. Parašyti po atskirą metodą kiekvienam veiksmui 
                    (sudėčiai ir atimčiai naudoti  int tipą, o visiems kitiems double).
                3. Su switch() patikrinti kokį veiksmą atlikti ir kiekviename case‘e išsikviesti  atitinkamą metodą, 
                    jei tokio case‘o nėra – informuoti vartotoją, jog tokio  veiksmo nėra.
                */

            Console.Write("Įveskite pirmą skaičių: ");
            double skaicius1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Įveskite antrą skaičių: ");
            double skaicius2 = Convert.ToDouble(Console.ReadLine());


            bool testiPrograma = true;
            while (testiPrograma)

            {
                Console.Write("Kokį veiksmą su šiais skaičiais norite atlikti, pasirinkite skaičių? (1 - sudėtis, 2 - atimtis, 3 - kėlimas 4 laipsniu sudėjus abu skaičius, 4 - kvadratinė šaknis sudėjus abu skaičius, 5 - baigti programą \n\r");
            
                string veiksmas = Console.ReadLine();

                switch (veiksmas)
                {
                    case "1":
                        Sudetis((int)skaicius1, (int)skaicius2);
                        break;
                    case "2":
                        Atimtis((int)skaicius1, (int)skaicius2);
                        break;
                    case "3":
                        KelimasKetvirtuojuLaipsniu(skaicius1, skaicius2);
                        break;
                    case "4":
                        KvadratineSaknis(skaicius1, skaicius2);
                        break;
                    case "5":
                        testiPrograma = false;
                        break;

                    default:
                        Console.WriteLine("Tokio veiksmo nėra.");
                        break;
                }
                
            }
           
            Console.ReadLine();
        }

        static void Sudetis(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Suma: {skaicius1 + skaicius2}");
        }

        static void Atimtis(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Skirtumas: {skaicius1 - skaicius2}");
        }

        static void KelimasKetvirtuojuLaipsniu(double skaicius1, double skaicius2)
        {
            Console.WriteLine($"Rezultatas: {Math.Pow(skaicius1 + skaicius2,4)}");
        }

        static void KvadratineSaknis(double skaicius1, double skaicius2)
        {
            Console.WriteLine($"Rezultatas: {Math.Sqrt(skaicius1 + skaicius2)}");
        }
    }
}

