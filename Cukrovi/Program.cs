using System.Collections;
using System.Security.Cryptography.X509Certificates;

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

 

     Recept lineckeCukrovi = new Recept
     ( "Linecke cukrovi",
       "140 g masla, 70 g cukr moucka, 210 g hladka mouka, 2 vejce, marmelada",
       "Mouku prosijte na val, pridejte cukr, maslo, zloutky. Co nejrychleji zpracovat testo a dat do lednicky. Troubu predehrat na 180stupnu. Z testa vyvalet plat silny cca 2mm. Vykrajovat kolecka, do poloviny vykrojit prazdny stred a nezme je prenaset na plech. Pect cca 5 minut. Vychladle cukrovi slepit marmeladou."

     );

        Recept muslicky = new Recept
        (
            "Muslicky s orechovou naplni",
            "250 g masla, 250 g cukr moucka, 250 g hladka mouka, 2 vejce, 100 g mletych orechu,  ", 
            "Smichat mouku, maslo, 1 vejce a 1 lzici vody a vypracovat hladke testo. Nechat odpocinout v lednici. Na napln smichat mlete orechy, 100g mouckoveho cukru a 1 vejce. Predehrat troubu na 180 stupnu. Z testa vyvalet plat cca 2 mm silny a vykrajet kolecka. Na kazde kolecko dat trochu naplne a prelozit napul. Muslicky prenest na plech a pect cca 10 minut do svetle zlate barvy. Jeste horke obalit v mouckovem cukru."

        );
        Recept pracny = new Recept
        ( "Pracny",
            "225 g masla, 70 g cukr moucka, 225 g hladka mouka, 50 g mletych orechu, 2 hrebicky, 0.5 lzicky skorice, 0.5 lzice kakaa",
            "Prisady zpracovat na pevne testo a polovinu obarvit kakaem. Nechat odpocinout v lednicce. Troubu predehrat na 170 stupnu. Potom vytlacit do formicek. Pect zhruba 5-7 minut. Po upeceni vyklepnout z formicek."

        );
        Recept vanilkoveRohlicky = new Recept
        (   "Vanilkove rohlicky",
            "170 g masla, 50 g cukr moucka, 210 g hladka mouka, 80 g vlaskych orechu, 20 g vanilkovy cukr ",
            "Vychlazene maslo nakrajet na kosticky, pridat ostatni suroviny a vypracovat pevne testo. Testo nechat odpocivat v lednicce. Pote z testa vyvalet silny valecek, nakrajet ho na kousky a ty potom tvarovat jako rohlicky. Troubu predehrat na 180 stupnu. Rohlicky pect 12-15 minut. Po upeceni nechat kratce zchladnout. Pote je obalit ve smesi mouckoveho a vanilkoveho cukru."

        );
       

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
                                vanilkoveRohlicky.VypisRecept();
                                break;
                            }
                        case "2":
                            {
                                lineckeCukrovi.VypisRecept();
                                break;
                            }
                        case "3":
                            {
                                pracny.VypisRecept();
                                break;
                            }
                        case "4":
                            {
                                muslicky.VypisRecept();
                                break;
                        }
                        
                        
                    }
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Mate doma tyto suroviny:");
                    
                    break;
                    }

        }



    }
}
