using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Cukrovi;

class Program
{

    static void Main(string[] args)
    {
        string pomlcky = new string('-', 20);
        Console.WriteLine(pomlcky + "ZAVERECNY PROJEKT" + pomlcky);
        Console.WriteLine("Uzivateli, zadej sve jmeno:");
        string jmeno = Console.ReadLine();
        if (String.IsNullOrEmpty(jmeno))
        {
            throw new ArgumentException("Uzivateli, nezadal jsi jmeno.");
        }


        DateTime stedryDen = new DateTime(2025, 12, 24);
        TimeSpan pocetDniDoVanoc = stedryDen - DateTime.Now;
        Console.WriteLine($"Ahoj {jmeno}, do Vanoc zbyva {pocetDniDoVanoc.Days} dni.");
        if (pocetDniDoVanoc.Days < 21)
        {
            Console.WriteLine("Je nejvyssi cas zacit pect cukrovi!");
        }
        else
        {
            Console.WriteLine("Do Vanoc casu dost, ale stejne si muzes projit recepty na cukrovi ;)");
        }


        Recept lineckeCukrovi = new Recept
        ("Linecke cukrovi",
            "Mouku prosit na val, pridat cukr, maslo, zloutky. Co nejrychleji zpracovat testo a dat do lednicky. Troubu predehrat na 180stupnu. Z testa vyvalet plat silny cca 2mm. Vykrajovat kolecka, do poloviny vykrojit prazdny stred a opatrne je prenaset na plech. Pect cca 5 minut. Vychladle cukrovi slepit marmeladou."
             );
        lineckeCukrovi.Suroviny = new List<ISurovina>()
           {
             new Surovina("maslo", 140, "g"),
             new Surovina("cukr moucka", 70, "g"),
             new Surovina("hladka mouka", 210, "g"),
             new Surovina("vejce", 2, "ks" ),
             new Surovina("marmelada", 100, "g")

           };

        Recept muslicky = new Recept
        (
            "Muslicky s orechovou naplni",
            "Smichat mouku, maslo, 1 vejce a 1 lzici vody a vypracovat hladke testo. Nechat odpocinout v lednici. Na napln smichat mlete orechy, 100g mouckoveho cukru a 1 vejce. Predehrat troubu na 180 stupnu. Z testa vyvalet plat cca 2 mm silny a vykrajet kolecka. Na kazde kolecko dat trochu naplne a prelozit napul. Muslicky prenest na plech a pect cca 10 minut do svetle zlate barvy. Jeste horke obalit v mouckovem cukru."

        );
        muslicky.Suroviny = new List<ISurovina>()
                {new Surovina ("maslo", 250, "g"),
                new Surovina ("cukr moucka", 250, "g"),
                new Surovina("hladka mouka", 250, "g"),
                new Surovina ("vejce", 2, "ks" ),
                new Surovina ("mlete orechy", 100, "g")

        };
        Recept pracny = new Recept
        ("Pracny",
            "Prisady zpracovat na pevne testo a polovinu obarvit kakaem. Nechat odpocinout v lednicce. Troubu predehrat na 170 stupnu. Potom vytlacit do formicek. Pect zhruba 5-7 minut. Po upeceni vyklepnout z formicek."

        );
        pracny.Suroviny = new List<ISurovina>()
            {
                new Surovina ("maslo", 225, "g"),
                new Surovina ("cukr moucka", 70, "g"),
                new Surovina("hladka mouka", 225, "g"),
                new Surovina ("mlete orechy", 50, "g"),
                new Surovina("hrebicky", 2, "ks"),
                new Surovina("skorice", 1, "kavova lzicka"),
                new Surovina ("kakao", 1, "lzice"),

            };
        Recept vanilkoveRohlicky = new Recept
        ("Vanilkove rohlicky",
        "Vychlazene maslo nakrajet na kosticky, pridat ostatni suroviny a vypracovat pevne testo. Testo nechat odpocivat v lednicce. Pote z testa vyvalet silny valecek, nakrajet ho na kousky a ty potom tvarovat jako rohlicky. Troubu predehrat na 180 stupnu. Rohlicky pect 12-15 minut. Po upeceni nechat kratce zchladnout. Pote je obalit ve smesi mouckoveho a vanilkoveho cukru."

        );
        vanilkoveRohlicky.Suroviny = new List<ISurovina>
            {
                new Surovina ("maslo", 170, "g"),
                new Surovina ("cukr moucka", 50, "g"),
                new Surovina("hladka mouka", 210, "g"),
                new Surovina ("mlete orechy", 80, "g"),
                new Surovina ("vanilkovy cukr", 20, "g"),

             };


        var zasoby = new List<ISurovina>
        {   new Surovina("mouka", 1000, "g"),
            new Surovina("cukr krystal", 1000, "g"),
            new Surovina("cukr moucka", 1000, "g"),
            new Surovina("kakao", 250, "g"),
            new Surovina("maslo", 250, "g"),
            new Surovina("vejce", 12, "ks"),
            new Surovina("orechy", 100, "g"),
            new Surovina("marmelada", 250, "g"),
            new Surovina("hrebicek", 20, "ks"),
            new Surovina("skorice", 10, "g"),
            new Surovina("vanilkovy cukr", 100, "g")
        };


        while (true)
        {
            Console.WriteLine("Vyber akci:");
            Console.WriteLine("1-zobrazit recepty");
            Console.WriteLine("2-zobrazit zasoby");
            Console.WriteLine("3 - ukonceni programu");
            int vstupUzivatele = int.Parse(Console.ReadLine());
            while ((vstupUzivatele == 1 || vstupUzivatele == 2 || vstupUzivatele == 3) == false)
            {
                Console.WriteLine("Nebylo zadáno platne cislo pro vyber akce. Opakuj vyber:");
                vstupUzivatele = int.Parse(Console.ReadLine());

            }

            switch (vstupUzivatele)
            {
                case 1:
                    {
                        Console.WriteLine("Vyber cislo receptu, ktery chces zobrazit:");
                        Console.WriteLine("1- vanilkove rohlicky");
                        Console.WriteLine("2- linecke");
                        Console.WriteLine("3- pracny");
                        Console.WriteLine("4- muslicky s orechovou naplni");
                        int vyberReceptu = int.Parse(Console.ReadLine());
                        while (vyberReceptu < 1 || vyberReceptu > 4)
                        {
                            Console.WriteLine("Nebylo zadáno platne cislo receptu. Opakuj vyber:");
                            vyberReceptu = int.Parse(Console.ReadLine());

                        }

                        switch (vyberReceptu)
                        {
                            case 1:
                                {
                                    vanilkoveRohlicky.VypisRecept();
                                
                                    break;
                                }
                            case 2:
                                {
                                    lineckeCukrovi.VypisRecept();
                                    break;
                                }
                            case 3:
                                {
                                    pracny.VypisRecept();
                                    break;
                                }
                            case 4:
                                {
                                    muslicky.VypisRecept();
                                    break;
                                }


                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Mate doma tyto suroviny:");
                        foreach (var polozka in zasoby)
                        {
                            Console.WriteLine($"{polozka.Mnozstvi} {polozka.Jednotky} {polozka.Jmeno}");

                        }

                        break;


                    }
                case 3:
                    Console.WriteLine("Ukoncuji apikaci.");
                    return;





            }



        }
    }
    }

