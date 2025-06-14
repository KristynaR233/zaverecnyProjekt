using System;

namespace Cukrovi;

public interface ISurovina
{
    public string Jmeno { get; set; }
    public double Mnozsti { get; set; }

    public enum Jednotky
    { g, ml, lzicka, lzice, kus }

    public enum Druh
    {
       mouka, cukrKrystal, cukrMoucka, kakao, maslo, vejce, orechy, mamelada, hrebicek, skorice, vanilkovyCukr
    }
    

}
