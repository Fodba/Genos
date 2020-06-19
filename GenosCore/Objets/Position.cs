using System;
using Textes;

namespace GenosCore.Objets
{
    public class Position
    {
        #region Champs
        private int limite;
        private int x;
        private int y;
        private int pas;
        private Directions direction;
        #endregion

        #region Constructeurs
        public Position() : this(2, 2)
        {
        }

        public Position(int p_limite, bool troisSix = false)
        {
        }

        public Position(int x, int y, int p_pas = 1)
        {
        }

        public override bool Equals(object obj)
        {
            Position pos = (Position)obj;
            if (pos.X == this.X && pos.Y == this.Y)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
        }
        #endregion

        #region Propriétés
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Directions Direction { get => direction; set => direction = value; }
        public int Pas { get => pas; set => pas = value; }
        public int Limite { get => limite; set => limite = value; }
        #endregion

        #region Méthodes
        public void ChangeX(SensH p_sens, int p_pas = 1, int p_limite = 0)
        {
        }

        public void ChangeY(SensV p_sens, int p_pas = 1, int p_limite = 0)
        {
        }

        public void ChangePosition(Directions direction, int p_pas = 1, int p_limite = 0)
        {
        }
        #endregion
    }
}
