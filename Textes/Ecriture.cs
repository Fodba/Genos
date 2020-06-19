using System;

namespace Textes
{
    public static class Ecriture
    {
        public static void Ecrire(this string str, string p_enTete = "")
        {
            Console.WriteLine("".Separation());
            if (p_enTete != "") Console.WriteLine(p_enTete.StringFormatCustom());
            else Console.WriteLine(str);
            Console.WriteLine("".Separation());
        }

        public static string StringFormatCustom(this string str, string p_enTete = "", string symbole = "")
        {
            string chaine = "";
            if (p_enTete != "") chaine += $"*****\t{p_enTete}\t*****\n";
            chaine += $"*****\t{str}{symbole}\t*****\n";
            return chaine;
        }

        public static string Separation(this string str)
        {
            return "********************************************";
        }
    }
}
