using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_34
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          Įvesti du skaičius iš konsolės
            Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti: Daugybą ar  dalybą
            Parašyti po atskirą metodą kiekvienam veiksmui (daugybai naudoti int tipą, o  dalybai double)
            Su if patikrinti kokį veiksmą atlikti ir išsikviesti atitinkamą metodą, jei tokio  veiksmo nėra – informuoti vartotoją, jog tokio veiksmo nėra.

          */

            Console.Write("Įveskite pirmą skaičių: ");
            double skaicius1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Įveskite antrą skaičių: ");
            double skaicius2 = Convert.ToDouble(Console.ReadLine());


            bool testiPrograma = true;
            while (testiPrograma)

            {
                Console.Write("Kokį veiksmą su šiais skaičiais norite atlikti, pasirinkite skaičių? (1 - daugyba, 2 - dalyba, 3 - baigti programą \n\r");

                string veiksmas = Console.ReadLine();

                if (veiksmas == "1")
                {
                    Daugyba((int)skaicius1, (int)skaicius2);
                }
                if (veiksmas == "2")
                { Dalyba((double)skaicius1, (double)skaicius2); }

                if (veiksmas == "3")
                { testiPrograma = false; }

                if ((veiksmas != "1") && (veiksmas != "2") && (veiksmas != "3"))
                { 
                        Console.WriteLine("Tokio veiksmo nėra."); 
                    }
    
            }

            Console.ReadLine();
        }

        private static void Dalyba(double skaicius1, double skaicius2)
        {
            Console.WriteLine($"Skaičių dalyba {skaicius1 / skaicius2}"); ;
        }

        private static void Daugyba(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Skaičių sandauga {skaicius1*skaicius2}");
        }
    }
}
