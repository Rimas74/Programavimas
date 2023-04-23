using System;

class Salis
{
    public string Pavadinimas;
    public string Prezidentas;
    public double Plotas;
    public int GyventojuSkaicius;
    public double VidutinisAtlyginimas;
    public int[] Augimas;

    // Konstruktorius 1 - be parametrų
    public Salis()
    {
        Pavadinimas = "Nenustatyta";
        Prezidentas = "Nenustatyta";
        Plotas = 0;
        GyventojuSkaicius = 0;
        VidutinisAtlyginimas = 0;
        Augimas = new int[5];
    }

    // Konstruktorius 2 - su visais parametrais
    public Salis(string pavadinimas, string prezidentas, double plotas, int gyventojuSkaicius, double vidutinisAtlyginimas, int[] augimas)
    {
        Pavadinimas = pavadinimas;
        Prezidentas = prezidentas;
        Plotas = plotas;
        GyventojuSkaicius = gyventojuSkaicius;
        VidutinisAtlyginimas = vidutinisAtlyginimas;
        Augimas = augimas;
    }

    // Konstruktorius 3 - su pavadinimu, prezidentu ir plotu
    public Salis(string pavadinimas, string prezidentas, double plotas)
    {
        Pavadinimas = pavadinimas;
        Prezidentas = prezidentas;
        Plotas = plotas;
        GyventojuSkaicius = 0;
        VidutinisAtlyginimas = 0;
        Augimas = new int[5];
    }

    // Konstruktorius 4 - su gyventoju skaiciumi ir vidutiniu atlyginimu
    public Salis(int gyventojuSkaicius, double vidutinisAtlyginimas)
    {
        Pavadinimas = "Nenustatyta";
        Prezidentas = "Nenustatyta";
        Plotas = 0;
        GyventojuSkaicius = gyventojuSkaicius;
        VidutinisAtlyginimas = vidutinisAtlyginimas;
        Augimas = new int[5];
    }

    // Metodas, kad išvestų visą informaciją apie šalį
    public void IsvestiInformacija()
    {
        Console.WriteLine("Šalies informacija:");
        Console.WriteLine("Pavadinimas: " + Pavadinimas);
        Console.WriteLine("Prezidentas: " + Prezidentas);
        Console.WriteLine("Plotas: " + Plotas);
        Console.WriteLine("Gyventojų skaičius: " + GyventojuSkaicius);
        Console.WriteLine("Vidutinis atlyginimas: " + VidutinisAtlyginimas);

        Console.WriteLine("Gyventojų gimimo rodikliai per 5 metus:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine((i + 1) + "-aisiais metais gimė: " + Augimas[i]);
        }
        Console.WriteLine(new string('-',70));
    }

    //public void RastiReiksme(int indeksas)
    //{
    //    if (indeksas < 0 || indeksas >= Augimas.Length)
    //    {
    //        Console.WriteLine("Neteisingas masyvo indeksas!");
    //        return;
    //    }

    //    Console.WriteLine($"Masyvo elementas {indeksas} yra {Augimas[indeksas]}");

    //    if (indeksas + 1 < Augimas.Length && Augimas[indeksas] > Augimas[indeksas + 1])
    //    {
    //        Console.WriteLine($"Masyvo elementas {indeksas + 1} yra {Augimas[indeksas + 1]}");
    //    }

    //}

}
class Program
{
    static void Main(string[] args)
    {
        Salis salis1 = new Salis("Lietuva", "Gitanas Nausėda", 65300, 2794000, 1067.34, new int[] { 34000, 32000, 31000, 30000, 29000 });
        Salis salis2 = new Salis("JAV", "Joe Biden", 9834000, 331000000, 51680.0, new int[] { 3300000, 3200000, 3100000, 3000000, 2900000 });
        Salis salis3 = new Salis("Kanada", "Justin Trudeau", 9985000, 37590000, 53000.0, new int[] { 380000, 370000, 360000, 350000, 340000 });
        Salis salis4 = new Salis("Estija", "Kersti Kaljulaid", 45227, 1319133, 1500.0, new int[] { 13312, 12120, 13532, 14367, 12894 });

        salis1.IsvestiInformacija();
        salis2.IsvestiInformacija();
        salis3.IsvestiInformacija();
        salis4.IsvestiInformacija();

        Console.ReadLine();
    }
}

