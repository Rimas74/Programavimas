using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. Liepkite vartotojui įvesti tris skaičius. Su switch patikrinkite pirmąjį skaičių:
ar jis lygus 1: išveskite visų trijų skaičių sumą;
ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
2. Liepkite vartotojui įvesti gyvūno rūšį. Su switch patikrinkite:
ar įvestas gyvūnas yra šuo;
ar įvestas gyvūnas yra katė;
ar įvestas gyvūnas yra žiurkėnas.
*/

namespace uzduotis_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            
            Console.WriteLine("įveskite tris skaičius atskirdami paspaudimu \"Enter\": ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

           switch (num1)
            {
                case 1:
                    Console.WriteLine($"Visų skaičių suma: {num1+num2+num3} ");
                    break;
                case 2:
                    Console.WriteLine($"Pirmo ir trečio skaičių skirtumas: {num1 - num3} ");
                    break;
                case 3:
                    Console.WriteLine($"Antro ir trečio skaičių sandauga: {num2 * num3} ");
                    break;
            }

            string rusis;
            Console.WriteLine("įveskite gyvūno rūšį: ");
            rusis = Console.ReadLine();
            switch (rusis)
            {
                case ("šuo"):
                    Console.WriteLine("gyvūnas yra šuo");
                    break;
                case ("katė"):
                    Console.WriteLine("gyvūnas yra katė");
                    break;
                case ("žiurkėnas"):
                    Console.WriteLine("gyvūnas yra žiurkėnas");
                    break;
                default:
                    Console.WriteLine("Nėra tokio gyvūno.");
                    break;

            }




        }
    }
}
