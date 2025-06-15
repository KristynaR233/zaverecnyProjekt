using System;
using Microsoft.VisualBasic;

namespace Cukrovi;

public class Zasoba : ISurovina
{
    public Zasoba(string jmeno, decimal mnozstvi, string jednotky)
    {
        Jmeno = jmeno;
        Mnozstvi = mnozstvi;
        Jednotky = jednotky;
    }

    public string Jmeno { get; set; }
    public decimal Mnozstvi { get; set; }
    
    public string Jednotky { get; set; }

    public string Druh { get; set; }

}      


 


