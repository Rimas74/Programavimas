using System;

/*Sukurkite bazinę klasę Gyvunas su protected kintamaisiais ir paveldinčia
klasę Gyvate. 
Paveldinčioje klasėje turi būti metodas, kuris išveda visus klasės  kintamuosius į ekraną.
Bazinės klasės konstruktorių panaudokite paveldinčioje klasėje.
Išveskite paveldinčios klasės kintamuosius į ekraną.
*/


public class Gyvunas
{
    protected string Rusis;
    protected int Amzius;
  

    public Gyvunas(string rusis, int amzius)
    {
        Rusis = rusis;
        Amzius = amzius;
    }
}

public class Gyvate : Gyvunas
{
    private string Savybes;
    public Gyvate(string rusis, int amzius,string savybes) : base(rusis, amzius) 
    { 
        Savybes = savybes;
    }

    public void Isvedimas()
    {
        Console.WriteLine($"Rūšis: {Rusis}");
        Console.WriteLine($"Amžius: {Amzius}");
        Console.WriteLine($"Savybės: {Savybes}");

        Console.WriteLine(new string ('-',50));
    }
}

public class Program
{
    public static void Main()
    {
        Gyvate gyvate = new Gyvate("Zaltys", 5, "margas");
        Gyvate gyvate2 = new Gyvate("Angis", 2, "nuodinga");
        gyvate.Isvedimas();
        gyvate2.Isvedimas();
    }
}
