using System;
using System.Collections.Generic;
using System.Linq;

class Mokinys
{
    public string vardas;
    public string pavarde;
    public int amzius;
    public int klase;
    public List<int> pazymiai;

    public Mokinys(string vardas, string pavarde, int amzius, int klase, List<int> pazymiai)
    {
        this.vardas = vardas;
        this.pavarde = pavarde;
        this.amzius = amzius;
        this.klase = klase;
        this.pazymiai = pazymiai;
    }

    public void IsvestiInformacija()
    {
        Console.WriteLine($"Vardas: {vardas}");
        Console.WriteLine($"Pavardė: {pavarde}");
        Console.WriteLine($"Amžius: {amzius}");
        Console.WriteLine($"Klasė: {klase}");
        Console.Write($"Pažymiai: ");
        foreach (int pazymys in pazymiai)
        {
            Console.Write($"{pazymys} ");
        }
        Console.WriteLine();
    }

    public void KadaBaigsMokykla()
    {
        int liko = 12 - klase;
        if (liko > 0)
        {
            Console.WriteLine($"Mokinys baigs mokyklą už {liko} metų.");
        }
        else
        {
            Console.WriteLine("Mokinys baigs mokyklą šiais metais.");
        }
    }

    public int KiekDidesniuPazymiuUzKetverta(Mokinys mokinys)
    {
        int kiekPazymiu = 0;
        foreach (int pazymys in mokinys.pazymiai)
        {
            if (pazymys > 4)
            {
                kiekPazymiu++;
            }
        }
        return kiekPazymiu;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Mokinys> mokiniai = new List<Mokinys>();
        mokiniai.Add(new Mokinys("Jonas", "Jonaitis", 16, 10, new List<int> { 7, 8, 6, 9, 7 }));
        mokiniai.Add(new Mokinys("Petras", "Petraitis", 17, 11, new List<int> { 9, 9, 8, 8, 9 }));
        mokiniai.Add(new Mokinys("Ona", "Onaite", 15, 12, new List<int> { 10, 10, 9, 8, 10 }));

        foreach (Mokinys mokinys in mokiniai)
        {
            mokinys.IsvestiInformacija();
            mokinys.KadaBaigsMokykla();
            Console.WriteLine($"Geriausias pažymys: {mokinys.pazymiai.Max()}");
            Console.WriteLine($"Blogiausias pažymys: {mokinys.pazymiai.Min()}");
            Console.WriteLine(new string ('*',50));
        }
    }
}