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
            while (true)
            {
                Console.Write("2. Įveskite sveiką teigiamą skaičių (išskyrus 1): ");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num == 1)
                    {
                        Console.WriteLine("Įvestas skaičius negali būti lygus 1, įveskite kitą skaičių.");
                        continue;
                    }
                    if (num <= 0)
                    {
                        Console.WriteLine("Įvestas skaičius turi būti teigiamas, įveskite kitą skaičių.");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Netinkamas formato skaičius, įveskite kitą skaičių.");
                }
            }

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
