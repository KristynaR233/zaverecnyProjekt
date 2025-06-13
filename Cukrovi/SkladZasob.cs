using System;
using System.Collections.Generic;

namespace Cukrovi;

public class SkladZasob
{
    Zasoba mouka = new Zasoba() { Surovina = "mouka", Mnozstvi = 1000 };
    Zasoba cukrKrystal = new Zasoba() { Surovina = "cukr krystal", Mnozstvi = 1000 };
    Zasoba cukrMoucka = new Zasoba() { Surovina = "cukr moucka", Mnozstvi = 1000 };
    Zasoba kakao = new Zasoba() { Surovina = "kakao", Mnozstvi = 250 };
    Zasoba maslo = new Zasoba() { Surovina = "maslo", Mnozstvi = 250 };
    Zasoba vejce = new Zasoba() { Surovina = "maslo", Mnozstvi = 12 };
    Zasoba orechy = new Zasoba() { Surovina = "orechy", Mnozstvi = 100 };
    Zasoba marmelada = new Zasoba() { Surovina = "marmalada", Mnozstvi = 250 };
    Zasoba hrebicky = new Zasoba() { Surovina = "hrebicek", Mnozstvi = 20 };
    Zasoba skorice = new Zasoba() { Surovina = "skorice", Mnozstvi = 20 };
  Zasoba vanilkovyCukr = new Zasoba() { Surovina = "vanilkovy cukr", Mnozstvi = 100 };


    List<Zasoba> seznamZasobVeSkladu = new List<Zasoba>()
    
    {mouka, cukrKrystal, cukrMoucka, kakao, maslo, vejce, orechy, marmelada, hrebicky, skorice};



    public void VypisZasoby()
    {
        foreach (var surovina in seznamZasobVeSkladu)
        
          Console.WriteLine(surovina);
        }

    }


