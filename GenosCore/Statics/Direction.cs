using GenosCore.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenosCore.Statics
{
    public static class Direction
    {
        public static SensH SensHorizontal(this Position positionDeDepart, Position position2) { }

        public static SensV SensVertical(this Position positionDeDepart, Position position2) { }

        public static Directions DirectionFinale(this Position positionDeDepart, Position position2) { }

        public static Directions DirectionAleatoire(this Position positionDeDepart) { }


    }
}
