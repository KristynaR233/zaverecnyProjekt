using System;

namespace Cukrovi;

public class VanilkoveRohlicky : Recept
{
    string nazev = "Vanilkove rohlicky";
    string suroviny = "170 g masla, 50 g cukr moucka, 210 g hladka mouka, 80 g vlaskych orechu, 20 g vanilkovy cukr ";

    string postup = "Vychlazene maslo nakrajet na kosticky, pridat ostatni suroviny a vypracovat pevne testo. Testo nechat odpocivat v lednicce. Pote z testa vyvylet silny valecek, nakrajet ho na kousky a ty potom tvarovat jako rohlicky. Troubu predehrat na 180 stupnu. Rohlicky pect 12-15 minut. Po upeceni nechat kratce zchladnout a pote je obalit ve smesi mouckoveho a vanilkoveho cukru.";

    public void VypisRecept()
    {
        Console.WriteLine($"{nazev}");
        Console.WriteLine($"Seznam suroviny: {suroviny.Split(",")}");
        Console.WriteLine($"Postup: {postup}");
       

    }
}

