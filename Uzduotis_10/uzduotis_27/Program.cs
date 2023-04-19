using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Susikurti žodžių sąrašą. Rasti trumpiausią ir ilgiausią žodžius, juos išvesti į  ekraną, prie kiekvieno pasakant iš kiek raidžių jis yra sudarytas.
            Tip: string kintamasis iš tiesų yra char masyvas, todėl galite naudoti
            zodis.Length
            */
            Console.WriteLine("Pirmas budas, panaudojant Linq biblioteka.");
            Console.WriteLine("Pirmas žodžių sąrašas:");

            List<string> zodziai = new List<string> { "labas", "rytas", "Lietuva", "Europa", "pasaulis" };
            foreach (string s in zodziai)
            { 
                Console.Write(s +", "); 
            }

            string trumpiausias = zodziai.OrderBy(zodis => zodis.Length).First();
            string ilgiausias = zodziai.OrderByDescending(zodis => zodis.Length).First();
            
            Console.WriteLine();
            Console.WriteLine($"Trumpiausias žodis yra '{trumpiausias}', jis yra sudarytas iš {trumpiausias.Length} raidžių.");
            Console.WriteLine($"Ilgiausias žodis yra '{ilgiausias}', jis yra sudarytas iš {ilgiausias.Length} raidžių.");

            Console.WriteLine();
            Console.WriteLine(new string('-',70));
            Console.WriteLine();

            Console.WriteLine("Antras budas, panaudojant pirmus zodzius kaip pirmus kintamuosius, " +
                "bei su jais lyginant kitu zodziu ilgius.");
            Console.WriteLine("Antras žodžių sąrašas:");

            List<string> zodziai2 = new List<string> { "kaminas", "naktis", "Palanga", "autobusas", "kur","pasaulinis" };
            foreach (string s in zodziai2)
            {
                Console.Write(s + ", ");
            }
            string trumpiausias2 = zodziai2[0];
            string ilgiausias2 = zodziai2[0];

            foreach (string zodis in zodziai2)
            {
                if (zodis.Length < trumpiausias2.Length)
                {
                    trumpiausias2 = zodis;
                }

                if (zodis.Length > ilgiausias2.Length)
                {
                    ilgiausias2 = zodis;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Trumpiausias žodis: {0} ({1} raidžių)", trumpiausias2, trumpiausias2.Length);
            Console.WriteLine("Ilgiausias žodis: {0} ({1} raidžių)", ilgiausias2, ilgiausias2.Length);
        }
    }
}
