using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. Susikurkite savaitės temperatūrų rodmenų masyvą. Raskite:
žemiausią temperatūrą;
didžiausią temperatūrą;
vidurkį;
Temperatūrų, esančių žemiau už vidurkį, kiekį;
Temperatūrų, esančių aukščiau už vidurkį, kiekį.

2. Susikurkite studentų pažymių masyvą. Raskite:
geriausią pažymį;
kiek mokinių yra gavę dešimtukus;
kiek mokinių yra gavę neigiamą pažymį (žemiau nei 4);
pažymių vidurkį.
*/

namespace uzduotis_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.

            Random random = new Random();
            double[] temperatures = new double[7];

            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = random.NextDouble() * 30 ; // generates temperature between 10 and 30 degrees Celsius
            }
            // print out the temperatures
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"Temperature for day {i + 1}: {temperatures[i]:F1} °C");
            }

            Console.WriteLine($"Lowest week's temperature is {temperatures.Min():F1}°C.");
            Console.WriteLine($"Highest week's temperature is {temperatures.Max():F1}°C.");
            Console.WriteLine($"Average week's temperature is {temperatures.Average():F1}°C.");

            int countLower = 0;
            int countHigher = 0;
            foreach (var number in temperatures)
            {
                if (number < temperatures.Average())
                {
                    countLower++;
                }
                if (number > temperatures.Average())
                {
                    countHigher++;
                }
            }
            Console.WriteLine($"Number of days with the temperature lower than week's average is {countLower}.");
            Console.WriteLine($"Number of days with the temperature higher than week's average is {countHigher}.");

            Console.WriteLine();
            Console.WriteLine(new string ('-',50));
            Console.WriteLine();

            // 2.

            Random random1 = new Random();
            int[] marks = new int[5];

            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = random.Next(1,11); // generates student marks between 0 and 10 
            }
            // print out the students marks

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Student's {i + 1} mark is: {marks[i]} ");
            }

            int countTen = 0;
            int countNegative = 0;

            foreach (var mark in marks)
            {
                if (mark == 10)
                {
                    countTen++;
                }
                if (mark < 4)
                {
                    countNegative++;
                }
            }
            
            Console.WriteLine($"Best student mark is {marks.Max()}.");
            Console.WriteLine($"10 points earned {countTen} {(countNegative == 1 ? "student" : "students")}.");
            Console.WriteLine($"Lower than 4 points earned by {countNegative} {(countNegative == 1 ? "student" : "students")}.");
            Console.WriteLine($"Average student's mark is {marks.Average()}.");
        }
    }
}
