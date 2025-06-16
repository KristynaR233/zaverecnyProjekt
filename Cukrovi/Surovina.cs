using System;

namespace Cukrovi;

public class Surovina : ISurovina
{
    public string Jmeno { get; }
    public double Mnozstvi { get; set; }
    public string Jednotky { get; set; }
    public string Druh { get; set; }


    public Surovina(string jmeno, double mnozstvi, string jednotky)
    {
        Jmeno = jmeno;
        Mnozstvi = mnozstvi;
        Jednotky = jednotky;
        

    }

  
    

}
