using System;

namespace Cukrovi;

public class Recept 
{
    public string Nazev { get; }
    public List<ISurovina> Suroviny { get; set; }

    public string Postup { get; set; }

    public Recept(string nazev, string postup)
    {
        Nazev = nazev;
        Suroviny = new List<ISurovina>();
        Postup = postup;
 
        
    }
    
    public void VypisRecept()
    {
        Console.WriteLine($"** {Nazev} **");
        Console.WriteLine("Seznam surovin:");
        foreach (var seznam in Suroviny)
        {
            Console.WriteLine($"{seznam.Mnozstvi} {seznam.Jednotky} {seznam.Jmeno}");
        }
        
        Console.WriteLine("Postup:");
        List<string> postupVRadkach = Postup.Split(".").ToList();
        foreach (string polozka in postupVRadkach)
        {
            Console.WriteLine($"- {polozka}.");
        }
        


    }


}



