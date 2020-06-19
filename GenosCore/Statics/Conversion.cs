using GenosCore.Objets;
using System.Text.RegularExpressions;

namespace GenosCore.Statics
{
    public static class Conversion
    {
        public static string enTete = "";

        public static Position StringToPosition(this string str)
        {
            enTete = "StringToPosition";
            if (str.IsPosition())
            {
                Position p = new Position();
                string[] coord = str.Split(',');
                if (coord.Length > 1)
                {
                    p.X = int.Parse(coord[0].ToString());
                    p.Y = int.Parse(coord[1].ToString());
                }
                else
                {
                    string[] coord2 = str.Split('.');
                    if (coord2.Length > 1)
                    {
                        p.X = int.Parse(coord2[0].ToString());
                        p.Y = int.Parse(coord2[1].ToString());
                    }
                }
                return p;
            }
            else
            {
                return null;
            }
        }


        public static bool IsPosition(this string str)
        {
            Regex rx = new Regex("^(\\d+?[\\.\\,]\\d+?)$");
            return rx.IsMatch(str);
        }
    }
}
