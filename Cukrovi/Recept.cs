using System;

namespace Cukrovi;

public class Recept
{
    public string Nazev { get; set; }
    public string Suroviny { get; set; }
    public string Postup { get; set; }

    public Recept(string nazev, string suroviny, string postup)
    {
        Nazev = nazev;
        Suroviny = suroviny;
        Postup = postup;
    
        
    }
    
    public void VypisRecept()
    {
        Console.WriteLine($"**{Nazev}**");
        Console.WriteLine($"Seznam surovin: {Suroviny.Split(",")}");
        List<string> postupVRadkach = Postup.Split(".").ToList();
        foreach (string polozka in postupVRadkach)
        {
            Console.WriteLine($"- {polozka}.");
        }
        


    }


}



