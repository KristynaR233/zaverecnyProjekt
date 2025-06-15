using System;

namespace Cukrovi;

public interface ISurovina
{
    string Jmeno { get; }
    decimal Mnozstvi { get; set; }
    string Jednotky { get; set; }
    string Druh { get; set; }
  
    

}
