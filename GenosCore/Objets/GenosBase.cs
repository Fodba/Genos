using System;

namespace GenosCore.Objets
{
    public class GenosBase
    {
        #region Champs
        private Position position;
        private int limite;
        private GenosBase cible;


        #endregion

        #region Constructeurs
        public GenosBase() : this(2, 2)
        {
        }

        public GenosBase(int x, int y)
        {
        }

        public GenosBase(int limite, bool troisSix = false)
        {
        }
        #endregion

        #region Propriétés
        public Position Position { get => position; set => position = value; }
        public GenosBase Cible { get => cible; set => cible = value; }
        #endregion


        #region Méthodes

        public void seDeplacer(int pas = 1, int limite = 0)
        {
            throw new NotImplementedException();
        }

        public void seDeplacer(Directions direction, int pas = 1, int limite = 0)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
