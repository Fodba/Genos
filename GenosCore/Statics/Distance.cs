using GenosCore.Objets;

namespace GenosCore.Statics
{
    public static class Distance
    {
        public static int EcartX(this Position p_pos1, Position p_pos2) { }

        public static int EcartY(this Position p_pos1, Position p_pos2) { }

        public static double Ecart(this Position p_pos1, Position p_pos2) { }

        public static Position PlusProchePosition(this Position p_pos1, Position[] tab_pos) { }

        public static Position PlusLointainePosition(this Position p_pos1, Position[] tab_pos) { }

        public static Position[] PositionsCroissantes(this Position p_pos1, Position[] tab_pos) { }

        public static Position[] PositionsDecroissantes(this Position p_pos1, Position[] tab_pos) { }

        public static GenosBase PlusProcheGenos(this GenosBase p_genos1, GenosBase[] tab_genos) { }

        public static GenosBase PlusLointainGenos(this GenosBase p_genos1, GenosBase[] tab_genos) { }

        public static GenosBase[] GenosCroissants(this GenosBase p_genos1, GenosBase[] tab_genos) { }

        public static GenosBase[] GenosDecroissants(this GenosBase p_genos1, GenosBase[] tab_genos) { }
    }
}
