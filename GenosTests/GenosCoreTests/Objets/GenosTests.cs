using GenosCore.Objets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenosTests.GenosCoreTests.Objets
{
    [TestClass]
    public class GenosTest
    {
        Genos genosDeReference = new Genos(0, 0);
        Genos genosTemoin = new Genos(0, 0);
        Genos genosTest = new Genos(3, 4);
        Genos[] tableauGenos;

        #region Choix de cible(s)

        #region Le plus proche
        [TestMethod]
        public void TestPlusProche()
        {
            tableauGenos = new Genos[2];
            Genos genos1 = new Genos(10, 8);

            tableauGenos[0] = genosTest;
            tableauGenos[1] = genos1;

            genosDeReference.DetermineCible(tableauGenos);

            Assert.AreEqual(genosTest, genosDeReference.Cible);
        }

        [TestMethod]
        public void TestPlusProche2()
        {
            tableauGenos = new Genos[3];
            Genos genos1 = new Genos(10, 8);
            Genos genos2 = new Genos(12, 1);
            Genos genos3 = new Genos(5, 6);

            tableauGenos[0] = genos1;
            tableauGenos[1] = genos2;
            tableauGenos[2] = genos3;

            genosDeReference.DetermineCible(tableauGenos);

            Assert.AreEqual(genos3, genosDeReference.Cible);
        }
        #endregion

        #endregion

        #region Déplacements

        #region Aléatoire
        [TestMethod]
        public void TestSeDeplacerAleatoire()
        {
            Genos genos = new Genos(0, 0);
            genosDeReference.seDeplacer();

            Assert.AreNotEqual(genos, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerAleatoireLimite()
        {
            Genos genos = new Genos(0, 0);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(pas, limite);

            Assert.AreEqual(genos, genosDeReference);
        }
        #endregion

        #region Haut
        [TestMethod]
        public void TestSeDeplacerHaut()
        {
            Genos genos = new Genos(0, -1);
            genosDeReference.seDeplacer(genos);

            Assert.AreEqual(genos, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerHautLimite()
        {
            Genos genos = new Genos(0, -1);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(genos, pas, limite);

            Assert.AreEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Haut Droite
        [TestMethod]
        public void TestSeDeplacerHautDroite()
        {
            Genos genos = new Genos(1, -1);
            genosDeReference.seDeplacer(genos);

            Assert.AreEqual(genos, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerHautDroiteLimite()
        {
            Genos genos = new Genos(1, -1);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(genos, pas, limite);

            Assert.AreEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Droite
        [TestMethod]
        public void TestSeDeplacerDroite()
        {
            Genos genos = new Genos(1, 0);
            genosDeReference.seDeplacer(genos);

            Assert.AreEqual(genos, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerDroiteLimite()
        {
            Genos genos = new Genos(1, 0);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(genos, pas, limite);

            Assert.AreNotEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Bas Droite
        [TestMethod]
        public void TestSeDeplacerBasDroite()
        {
            Genos genos = new Genos(1, 1);
            genosDeReference.seDeplacer(genos);

            Assert.AreEqual(genos, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerBasDroiteLimite()
        {
            Genos genos = new Genos(1, 1);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(genos, pas, limite);

            Assert.AreNotEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Bas
        [TestMethod]
        public void TestSeDeplacerBas()
        {
            Genos genos = new Genos(0, 1);
            genosDeReference.seDeplacer(genos);

            Assert.AreEqual(genos, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerBasLimite()
        {
            Genos genos = new Genos(0, 1);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(genos, pas, limite);

            Assert.AreNotEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Bas Gauche
        [TestMethod]
        public void TestSeDeplacerBasGauche()
        {
            Genos genos = new Genos(-1, 1);
            genosDeReference.seDeplacer(genos);

            Assert.AreEqual(genos, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerBasGaucheLimite()
        {
            Genos genos = new Genos(-1, 1);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(genos, pas, limite);

            Assert.AreNotEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Gauche
        [TestMethod]
        public void TestSeDeplacerGauche()
        {
            Genos genos = new Genos(-1, 0);
            genosDeReference.seDeplacer(genos);

            Assert.AreEqual(genos, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerGaucheLimite()
        {
            Genos genos = new Genos(-1, 0);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(genos, pas, limite);

            Assert.AreNotEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Haut Gauche
        [TestMethod]
        public void TestSeDeplacerHautGauche()
        {
            Genos genos = new Genos(-1, -1);
            genosDeReference.seDeplacer(genos);

            Assert.AreEqual(genos, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerHautGaucheLimite()
        {
            Genos genos = new Genos(-1, -1);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(genos, pas, limite);

            Assert.AreNotEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #endregion
    }
}
