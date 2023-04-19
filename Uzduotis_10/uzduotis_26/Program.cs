using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace uzduotis_26
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Sugeneruokite atsitiktinio dydžio sąrašą, kurį užpildykite atsitiktiniais  skaičiais nuo 1 iki 100. Raskite:
            1. mažiausią skaičių;
            2. didžiausią skaičių;
            3. vidurkį;
            4. kiek skaičių yra žemesni už vidurkį;
            5. lyginių skaičių sumą;
            */
            Random rnd = new Random();
            List<int> randomList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = rnd.Next(1, 101);
                randomList.Add(randomNumber);
            }

            int count = 0;
            int suma = 0;

            Console.WriteLine("1. Sugeneruotas sąrašas:");
            foreach (int number in randomList)
            {
                Console.Write(number + " ");
                if (number < randomList.Average())
                {
                    count++;
                }
                if (number % 2 == 0)
                {
                    suma += number;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine($"1.1. mažiausias skaičius sąraše: {randomList.Min()}");
            Console.WriteLine($"1.2. didžiausias skaičius sąraše: {randomList.Max()}");
            Console.WriteLine($"1.3. vidurkis: {randomList.Average()}");
            Console.WriteLine($"1.4. žemesni už vidurkį yra {count} skaičiai");
            Console.WriteLine($"1.5. lyginių skaičių suma yra lygi {suma}");
            
            
            Console.WriteLine(new string('-',50));
            

            /*Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą.  
             * Tegul jis užpildo šį sąrašą duomenimis, įvedant juos per konsolę. Raskite:
                1. didžiausią pažymį;
                2. mažiausią pažymį;
                3. vidurkį;
                */

            Console.Write("2. Kiek studentų pažymių norite suvesti į sąrašą? ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> pazymiai = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Įveskite {i + 1}-ąjį pažymį: ");
                int pazymys = Convert.ToInt32(Console.ReadLine());
                pazymiai.Add(pazymys);
            }


            Console.WriteLine($"2.1. didžiausias pažymys: {pazymiai.Max()}");
            Console.WriteLine($"2.2. mažiausias pažymys: {pazymiai.Min()}");
            Console.WriteLine($"2.3. pažymių vidurkis: {pazymiai.Average():N2}");

        }
    }
}
