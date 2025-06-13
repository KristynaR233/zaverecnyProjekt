using System.Collections;

namespace Cukrovi;

class Program
{
    static void Main(string[] args)
    {
        string pomlcky = new string('-', 20);
        Console.WriteLine(pomlcky + "ZAVERECNY PROJEKT" + pomlcky);
        Console.WriteLine("Uzivateli, zadej sve jmeno:");
        string jmeno = Console.ReadLine();
        DateTime stedryDen = new DateTime(2025, 12, 24);
        TimeSpan pocetDniDoVanoc = stedryDen - DateTime.Now;
        Console.WriteLine($"Ahoj {jmeno}, do Vanoc zbyva {pocetDniDoVanoc.Days} dni. Je cas zacit pect cukrovi.");

        Console.WriteLine("Vyber akci:");
        Console.WriteLine("1-zobrazit recepty");
        Console.WriteLine("2-zobrazit zasoby");
        string vstupUzivatele = Console.ReadLine();
        switch (vstupUzivatele)
        {
            case "1":
                {
                    Console.WriteLine("Vyber cislo receptu, ktery chces zobrazit:");
                    Console.WriteLine("1- vanilkove rohlicky");
                    Console.WriteLine("2- linecke");
                    Console.WriteLine("3- pracny");
                    Console.WriteLine("4- muslicky s orechovou naplni");
                    string vyberReceptu = Console.ReadLine();
                    switch (vyberReceptu)
                    {
                        case "1":
                            {
                                VanilkoveRohlicky.VypisRecept();
                                break;
                            }
                        case "2":
                            {
                                break;
                            }
                        case "3":
                            {
                                break;
                            }
                        case "4":
                            {
                                break;
                        }
                        
                        
                    }
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Mate doma tyto suroviny:");
                    //SkladZasob.VypisZasoby();
                    break;
                    }

        }



    }
}
