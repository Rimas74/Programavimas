using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Sukurti void tipo metodą, kuriam paduosim masyvą.
                1. Metodas turi išvesti masyvo sumą (sumai skaičiuoti naudoti for ciklą ir .Sum()  funkciją. 
                2. Tuomet metodas išves į konsolę 2 tokias pačias sumas suskaičiuotas  skirtingais būdais)
                Išsikviesti metodą.

             */

            Program p= new Program();

            Random random = new Random();
            int[] masyvas = new int[3];

            Console.WriteLine("Masyvas:");

            for (int i = 0; i < masyvas.Length; i++)
                {
                    masyvas[i] = random.Next(1, 10); // skaičiai nuo 1 iki 10
                    Console.Write(masyvas[i] + ", ");
                }
            Console.WriteLine();
            p.Sumos(masyvas);
         }


            // 1.
            void Sumos(int[] masyvas)
            {
                int suma1 = 0;
                for (int i = 0; i < masyvas.Length; i++)
                {
                    suma1 += masyvas[i];
                }
                Console.WriteLine($"Masyvo suma (naudojant for ciklą): {suma1}");

                // 2.

                int suma2 = masyvas.Sum();
                Console.WriteLine($"Masyvo suma (naudojant .Sum() funkciją): {suma2}");
            }

        }
    }

