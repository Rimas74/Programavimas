using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_32
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          Paprašyti įvesti vartotojo vardą.
            Sukurti string tipo metodą, kuris gražina frazę pvz „Sveiki, Mantas“.
            Išvesti šią frazę į konsolę.
            */

            Console.WriteLine("įveskite savo vardą: ");
            Console.WriteLine(Vardas(Console.ReadLine()));
         }

        private static string Vardas(string v)
        {
            return $"Sveiki,{v}!";
        }
    }
}
