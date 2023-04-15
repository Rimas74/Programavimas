using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Tikslas:
Suskaičiuoti, kiek duonos kepalų kepykla sugebės iškepti per dieną.
Patikrinti, ar kepykla spės iškepti visus tos dienos užsakymus, jei ne, suskaičiuoti, kiek kepalų nespės iškepti.
Suskaičiuoti, kiek kepykla uždirbs pelno iš visų tą dieną iškeptų duonos kepalų.

Iš anksto žinoma informacija:
Darbo valandų per dieną - 8 val.
Vartotojo įvedama informacija:
Kiek darbuotojas gali iškepti kepalų per valandą.
Kiek darbuotojų turi kepykla.
Vieno kepalo savikaina.
Vieno kepalo pardavimo kaina.
Kiek kepykla turi tą dieną iškepti kepalų (užsakymai).

 */
namespace uzduotis_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int workingHours = 8;
            int breadsPerHour, numEmployees, breadCost, breadPrice, numOrders;
            int breadsPerDay, totalCost, totalRevenue, totalProfit;

            // Input information from the user
            Console.Write("Enter the number of breads that can be baked per hour: ");
            breadsPerHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of employees in the bakery: ");
            numEmployees = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the cost of producing one bread: ");
            breadCost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the selling price of one bread: ");
            breadPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of breads the bakery needs to bake today: ");
            numOrders = Convert.ToInt32(Console.ReadLine());

            // Calculate the total number of breads that can be baked in a day
            breadsPerDay = breadsPerHour * workingHours * numEmployees;

            // Determine if the bakery can fulfill all the orders
            if (breadsPerDay >= numOrders)
            {
                Console.WriteLine("The bakery can fulfill all orders.");
                totalRevenue = numOrders * breadPrice;
                totalCost = numOrders * breadCost;
            }
            else
            {
                Console.WriteLine("The bakery cannot fulfill all orders.");
                totalRevenue = breadsPerDay * breadPrice;
                totalCost = breadsPerDay * breadCost;
            }

            // Calculate the total profit
            totalProfit = totalRevenue - totalCost;

            Console.WriteLine("The bakery can bake {0} breads in a day.", breadsPerDay);
            Console.WriteLine("The total profit for the day is {0} euros.", totalProfit);
        }
    }
}
