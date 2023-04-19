using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Parašykite metodą, kuris pasisveikintų su vartotoju.
            Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
            Visi šie duomenys yra duodami metodui, kuris visą šią informaciją išveda
            formatuotai
            */
            Pasisveikinti();
        }
        public static void Pasisveikinti()
        {
            Console.Write("Įveskite savo vardą:\n");
            string vardas = Console.ReadLine();

            Console.Write("Įveskite savo amžių:\n");
            int amzius = Convert.ToInt32(Console.ReadLine());

            Console.Write("Įveskite savo hobio pavadinimą:\n");
            string hobis = Console.ReadLine();

            Console.WriteLine($"Labas, {vardas} ({amzius} m.).\nJūsų įrašytas hobis: {hobis}.");
            
        }
    }
}
