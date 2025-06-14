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
        Console.WriteLine($"{Nazev}");
        Console.WriteLine($"Seznam suroviny: {Suroviny.Split(",")}");
        Console.WriteLine($"Postup: {Postup}");


    }


}



