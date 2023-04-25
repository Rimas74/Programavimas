using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Raskite visų skaičių nuo 1 iki 100 sumą.
Raskite visų lyginių skaičių nuo 20 iki 40 sumą.
Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.
Rasti visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba
5, sumą.
Pavyzdys:
Visi skaičiai mažesni už 10 ir kurie dalinasi iš 3 arba 5 yra: 3, 5, 6, 9.
Šių skaičių suma yra 23.
Turite gauti 233168 atsakymą.
*/

namespace uzduotis_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 0; i < 101; i++)
            {
                suma += i;
            }
            Console.WriteLine($"1. 1..100 skaičių suma: {suma}.");

            int suma1 = 0;
            for (int i = 20; i < 41; i+=2)
            {
                suma1 += i;
            }
            Console.WriteLine($"2. 20..40 lyginių skaičių suma: {suma1}.");

            int suma2 = 0;
            for (int i = 31; i < 61; i += 2)
            {
                suma2 += i;
            }
            Console.WriteLine($"3. 30..60 nelyginių skaičių suma: {suma2}.");

            int suma3 = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i%5==0))
                        {
                    suma3 += i;
                }               
            }
            Console.WriteLine($"4. 0 ..1000 skaičių kurie be liekanos dalinasi iš 3 arba 5 yra: {suma3}.");
        }
    }
}
