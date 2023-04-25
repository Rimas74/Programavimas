using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_25
{
    internal class Program
    {
        static void Main(string[] args)
        {/*1. Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant tarpu. 
          * Rasti  didžiausią pažymį.
          */

            Console.WriteLine("Įveskite 5 pažymius, atskirdami juos tarpu:");

            // Nuskaitome vartotojo įvestus pažymius ir juos konvertuojame į masyvą
            string pazymiaiString = Console.ReadLine();
            int[] pazymiai = Array.ConvertAll(pazymiaiString.Split(' '), Convert.ToInt32);

            // Rasti didžiausią pažymį ir jį išvesti į konsolę
            int didziausias = pazymiai.Max();
            Console.WriteLine($"Didžiausias pažymys yra: {didziausias}");

            /* 2. Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant kableliu.
             * Rasti mažiausią pažymį.*/

            Console.WriteLine("Įveskite 5 pažymius, atskirdami juos kableliu:");

            // Nuskaitome vartotojo įvestus pažymius ir juos konvertuojame į masyvą
            string pazymiaiString1 = Console.ReadLine();
            int[] pazymiai1 = Array.ConvertAll(pazymiaiString1.Split(','), Convert.ToInt32);

            // Rasti mažiausią pažymį ir jį išvesti į konsolę
            int maziausias = pazymiai1.Min();
            Console.WriteLine($"Mažiausias pažymys yra: {maziausias}");
        }

    }
}
