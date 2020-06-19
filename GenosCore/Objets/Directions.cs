namespace GenosCore.Objets
{
    public enum SensH
    {
        DROITE, GAUCHE, NUL
    }
    public enum SensV
    {
        HAUT, BAS, NUL
    }

    public class Directions
    {
        public SensH sensHorizontal;
        public SensV sensVertical;

        public Directions()
        {
            sensHorizontal = SensH.NUL;
            sensVertical = SensV.NUL;
        }

        public Directions(bool aleatoire = false)
        {
            sensHorizontal = SensH.NUL;
            sensVertical = SensV.NUL;
        }

        public Directions(SensH sensHorizontal = SensH.NUL, SensV sensVertical = SensV.NUL)
        {
            this.sensHorizontal = sensHorizontal;
            this.sensVertical = sensVertical;
        }

        public override bool Equals(object obj)
        {
            return obj is Directions directions &&
                   sensHorizontal == directions.sensHorizontal &&
                   sensVertical == directions.sensVertical;
        }
    }
}
