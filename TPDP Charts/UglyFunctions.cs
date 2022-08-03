using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace TPDP_Charts
{
    static class UglyFunctions
    {  
    /*
     1 = Void
     2 = Fire
     3 = Water
     4 = Nature
     5 = Earth
     6 = Steel
     7 = Wind
     8 = Electric
     9 = Light
     10 = Dark
     11 = Nether
     12 = Poison
     13 = Fighting
     14 = Illusion
     15 = Sound
     16 = Warped
     17 = Dream
     
     O = Super Effective (2x)
     △ = Not Very Effective (0.5x)
     X = No Effect (0x)
    */
        public static string GetEffectivity (int pos)
        {
            if (pos == 1)
                return "Void";
            if (pos == 2)
                return "Fire";
            if (pos == 3)
                return "Water";
            if (pos == 4)
                return "Nature";
            if (pos == 5)
                return "Earth";
            if (pos == 6)
                return "Steel";
            if (pos == 7)
                return "Wind";
            if (pos == 8)
                return "Electric";
            if (pos == 9)
                return "Light";
            if (pos == 10)
                return "Dark";
            if (pos == 11)
                return "Nether";
            if (pos == 12)
                return "Poison";
            if (pos == 13)
                return "Fighting";
            if (pos == 14)
                return "Illusion";
            if (pos == 15)
                return "Sound";
            if (pos == 16)
                return "Warped";
            if (pos == 17)
                return "Dream";
            return "error";
        }

        public static string Find(string ability)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(TPDP_Charts.Properties.Resources.String2);
            var elements = doc.DocumentNode.SelectNodes("//tr");

            var tds = elements[0].SelectNodes("//td");
            for (int i = 0; i < tds.Count; i++)
                if (ability.Trim() == tds[i].InnerText.Trim())
                    return tds[i + 1].InnerText.Trim();
            
            return "";
        }
    
    }
}
