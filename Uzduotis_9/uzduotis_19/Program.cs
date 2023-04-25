using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Parašyti For ciklą, kuris suskaičiuotų, kiek skaičių intervale (0 – 1000) dalinasi iš 16.
2.Liepkite vartotojui įvesti teigiamą skaičių. While ciklo viduje skaičių kelkite vis
didesniu laipsniu ir jį išveskite į ekraną, kol skaičius netaps didesnis už 1500.

 */
namespace uzduotis_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 16 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("1. Intervale (0 - 1000) sveiką skaičių, kurie dalijasi be liekanos iš 16 yra: " + count);

            // 2.
            int num;

            do
            {
                Console.Write("Please enter a positive integer greater than 1: ");
            } while (!int.TryParse(Console.ReadLine(), out num) || num <= 1);


            int power = 2;
            int result = num;

            while (result <= 1500)
            {
                Console.WriteLine($"skaičių {num} pakelti {power} laipsniu yra {result}");
                power++;
                result = (int)Math.Pow(num, power);
            }



        }
    }
}
