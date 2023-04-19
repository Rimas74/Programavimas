using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Parašykite sumos funkciją su 3 parametrais, kuris gražina int tipo atsakymą.
            Parašykite dalmens funkciją su 2 parametrais, kuris gražina double tipo  atsakymą.
            Išsikvieskite abi funkcijas ir atsakymą išveskite į ekraną.
            */
            Program p= new Program();
            int v1 = 2;
            int v2 = 5;
            int v3 = 6;
            Console.WriteLine($"Skaičių {v1}, {v2}, {v3} suma: {p.Suma(v1,v2,v3)}.");
            Console.WriteLine($"Skaičių {v1}, {v2} dalyba: {p.Dalyba(v1,v2):N2}.");
        }

        private double Dalyba(int v1, int v2)
        {
            return (double)v1/v2;
        }

        private int Suma(int v1, int v2, int v3)
        {
            return v1+v2+v3;
        }
    }
}
