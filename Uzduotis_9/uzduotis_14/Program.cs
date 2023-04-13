using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Į ekraną išveskite kelis sunumeruotus pasirinkimus 
1 - stacionarus kompiuteris
2 - nešiojamas kompiuteris
3 - planšetė 
Liepkite vartotojui įvesti pasirinkimo numerį. 
Pagal įvestą numerį išveskite atitinkamą tekstą. Pvz:
nešiojamuoju kompiuteriu galite naudotis visur
stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje
planšete galite naudotis visur
Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.
 */
namespace uzduotis_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekstas = "pasirinkimai: \r\n1 - stacionarus kompiuteris" +
                "\r\n2 - nešiojamas kompiuteris\r\n3 - planšetė " +
                "\r\nįveskite pasirinkimo numerį.";
            Console.WriteLine(tekstas);
            string pasirinkimas=Console.ReadLine();
            switch (pasirinkimas)
            {
                case "1":
                    Console.WriteLine("stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje");
                    break;
                case "2":
                    Console.WriteLine("nešiojamuoju kompiuteriu galite naudotis visur");
                    break;
                case "3":
                    Console.WriteLine("planšete galite naudotis visur");
                    break;
                default: Console.WriteLine("tokio pasirinkimo nėra");
                    break;
            }        
        }
    }
}
