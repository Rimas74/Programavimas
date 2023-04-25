using System;

/*Sukurkite bazinę klasę Gyvunas su protected kintamaisiais ir paveldinčia
klasę Gyvate. 
Paveldinčioje klasėje turi būti metodas, kuris išveda visus klasės  kintamuosius į ekraną.
Bazinės klasės konstruktorių panaudokite paveldinčioje klasėje.
Išveskite paveldinčios klasės kintamuosius į ekraną.
*/

/*Base klasėje parašykite virtualų išvedimo metodą.
Paveldinčioje klasėje pakeiskite esamą išvedimo metodą, kad jis override‘intu
base klasės virtual metodą.
Base klasėje sukurkite private const kintamąjį, kadangi jo negalima pasiekti  už klasės ribų – base klasėje sukurkite public metodą, kuris išspausdina  private const kintamąjį. Panaudoję šį metodą, iškvieskite jį paveldinčios
klasės išvedimo metode.
*/

public class Gyvunas
{
    protected string Rusis;
    protected int Amzius;
    private const string Aprasymas = "Tai yra gyvūnas.";

    public Gyvunas(string rusis, int amzius)
    {
        Rusis = rusis;
        Amzius = amzius;
    }

    public virtual void Isvedimas()
    {
        Console.WriteLine(Aprasymas);
    }
}

public class Gyvate : Gyvunas
{
    private string Savybes;

    public Gyvate(string rusis, int amzius, string savybes) : base(rusis, amzius)
    {
        Savybes = savybes;
    }

    public override void Isvedimas()
    {
        base.Isvedimas();
        Console.WriteLine($"Rūšis: {Rusis}");
        Console.WriteLine($"Amžius: {Amzius}");
        Console.WriteLine($"Savybės: {Savybes}");
        Console.WriteLine(new string('-', 50));
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
