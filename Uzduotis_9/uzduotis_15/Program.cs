using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Parašyti for, kuris išvestų kiekvieną skaičių pradedant nuo 0 ir baigiant 10. Kiekvieną skaičių išvesti skirtingoje eilutėje.
Parašyti for, kuris išvestų kas antrą skaičių pradedant 0 ir baigiant 15.
Kiekvieną skaičių išvesti toje pačioje eilutėje, po kiekvieno skaičiaus dedant
tarpą.
Parašyti for, kuris išvestų kas trečią skaičių, pradedant 1 ir baigiant 20.
Kiekvieną skaičių išvesti toje pačioje eilutėje, tačiau parašant skaičių laužtiniuose skliaustuose. Pvz.: [1][4][7]...
Parašyti for, kuris eitų pro kiekvieną skaičių nuo 1 iki 10. Jame apsirašyti if
sąlygą, kuri patikrintų, ar dabartinis skaičius yra lyginis, jei taip – tai šį skaičių išvesti.
*/

namespace uzduotis_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++) 
            {
                Console.WriteLine(i);
            }
            
            for (int i = 0;i < 15; i+=2) 
            { 
                Console.Write(i +" ");
            }
            
            Console.WriteLine();
            for (int i = 0; i < 20; i += 3)
            {
                Console.Write("["+i + "]");
            }
           
            Console.WriteLine();
            for (int i = 0; i < 10; i ++)
            {
                if (i%2==0)
                        Console.Write(i +" ");
            }

        }
    }
}
 