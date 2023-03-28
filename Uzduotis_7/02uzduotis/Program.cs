using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            string comment = "Mano vardas";

            int totalOuterLenght = 29;
            int totalInnerLength = totalOuterLenght - 2;

            int commentLength = comment.Length > 27 ? 27 : comment.Length;
            int spacesBeforeComment = (27 - commentLength) / 2;
            int spacesAfterComment = 27 - commentLength - spacesBeforeComment;

            int nameLength = name.Length > 27 ? 27 : name.Length;
            int spacesBeforeName = (27 - nameLength) / 2;
            int spacesAfterName = 27 - nameLength - spacesBeforeName;


            Console.WriteLine("{0}", new string ('-', totalOuterLenght));
            Console.WriteLine("|{0}|", new string (' ', totalInnerLength));
            Console.WriteLine("|{0}|", new string(' ', totalInnerLength));
            Console.WriteLine("|{0}{1}{2}|", new string(' ', spacesBeforeComment), comment.Substring(0, commentLength), new string(' ', spacesAfterComment));
            Console.WriteLine("|{0}{1}{2}|", new string(' ', spacesBeforeName), name.Substring(0, nameLength), new string(' ', spacesAfterName));
            Console.WriteLine("|{0}|", new string(' ', totalInnerLength));
            Console.WriteLine("|{0}|", new string(' ', totalInnerLength));
            Console.WriteLine("{0}", new string('-', totalOuterLenght));
        }
    }
}
