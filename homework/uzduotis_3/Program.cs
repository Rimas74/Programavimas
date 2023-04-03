using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", new string('*', 4));
            Console.WriteLine("{0}{1}{2}", new string('*', 1), new string(' ',3), new string('*', 1));
            Console.WriteLine("{0}{1}{2}", new string('*', 1), new string(' ',3), new string('*', 1));
            Console.WriteLine("{0}", new string('*', 4));
        }
    }
}
