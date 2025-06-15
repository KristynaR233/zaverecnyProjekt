using System;

namespace Cukrovi;

public class Recept : ISurovina
{
    public string Nazev { get; set; }
    public PouziteSuroviny (string jmeno, double mnozstvi, string jednotky);
    {
        Jmeno = jmeno;
        Mnozstvi = mnozstvi;
        Jednotky = jednotky;
    }
    public string Postup { get; set; }

    public Recept(string nazev, List<ISurovina> suroviny, string postup)
    {
        Nazev = nazev;
        Suroviny = suroviny;
        Postup = postup;
    
        
    }
    
    public void VypisRecept()
    {
        Console.WriteLine($"** {Nazev} **");
        Console.WriteLine("Seznam surovin:");
        List<string> vypisSurovin = Suroviny.Trim().Split(",").ToList();
        foreach (string seznam in vypisSurovin)
        {
            Console.WriteLine($"{seznam}");
        }
        Console.WriteLine("Postup:");
        List<string> postupVRadkach = Postup.Split(".").ToList();
        foreach (string polozka in postupVRadkach)
        {
            Console.WriteLine($"- {polozka}.");
        }
        


    }


}



