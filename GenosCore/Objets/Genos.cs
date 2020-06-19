using System;

namespace GenosCore.Objets
{
    public class Genos : GenosBase
    {

        #region Constructeurs
        public Genos() : base()
        {
        }

        public Genos(int x, int y) : base(x, y)
        {
        }

        public Genos(int limite, bool troisSix = false) : base(limite, troisSix)
        {
        }
        #endregion



        #region Méthodes
        public void DetermineCible(Genos[] tableau)
        {
            throw new NotImplementedException();
        }

        public void seDeplacer(Genos genos, int pas = 1, int limite = 0)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
