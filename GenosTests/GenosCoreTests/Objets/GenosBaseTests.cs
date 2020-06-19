using System;
using GenosCore.Objets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenosTests.GenosCoreTests.Objets
{
    [TestClass]
    public class GenosBaseTests
    {
        int limite = 50;
        GenosBase genosDeReference = new GenosBase(0, 0);
        GenosBase genosTemoin = new GenosBase(0, 0);

        #region Creation

        #region Création par défaut
        [TestMethod]
        public void TestGenos()
        {
            GenosBase genos = new GenosBase();
            Assert.IsNotNull(genos);
        }

        [TestMethod]
        public void TestGenosPosition()
        {
            GenosBase genos = new GenosBase();
            Assert.IsNotNull(genos.Position);
        }

        [TestMethod]
        public void TestGenosPositionX()
        {
            GenosBase genos = new GenosBase();
            Assert.AreEqual(2, genos.Position.X);
        }

        [TestMethod]
        public void TestGenosPositionY()
        {
            GenosBase genos = new GenosBase();
            Assert.AreEqual(2, genos.Position.Y);
        }
        #endregion

        #region Création position définie
        [TestMethod]
        public void TestGenosDefini()
        {
            int x = 7;
            int y = 15;
            GenosBase genos = new GenosBase(x, y);
            Assert.IsNotNull(genos);
        }

        [TestMethod]
        public void TestGenosPositionDefini()
        {
            int x = 7;
            int y = 15;
            GenosBase genos = new GenosBase(x, y);
            Assert.IsNotNull(genos.Position);
        }

        [TestMethod]
        public void TestGenosPositionXDefini()
        {
            int x = 7;
            int y = 15;
            GenosBase genos = new GenosBase(x, y);
            Assert.AreEqual(x, genos.Position.X);
        }

        [TestMethod]
        public void TestGenosPositionYDefini()
        {
            int x = 7;
            int y = 15;
            GenosBase genos = new GenosBase(x, y);
            Assert.AreEqual(y, genos.Position.Y);
        }
        #endregion

        #region Création avec limite
        [TestMethod]
        public void TestGenosAleatoire()
        {
            bool troisSix = false;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsNotNull(genos);
        }

        [TestMethod]
        public void TestGenosPositionAleatoire()
        {
            bool troisSix = false;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsNotNull(genos.Position);
        }

        [TestMethod]
        public void TestGenosPositionXAleatoire1()
        {
            bool troisSix = false;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsTrue(genos.Position.X < limite);
        }

        [TestMethod]
        public void TestGenosPositionXAleatoire2()
        {
            bool troisSix = false;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsTrue(genos.Position.X > 0);
        }

        [TestMethod]
        public void TestGenosPositionYAleatoire1()
        {
            bool troisSix = false;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsTrue(genos.Position.Y < limite);
        }

        [TestMethod]
        public void TestGenosPositionYAleatoire2()
        {
            bool troisSix = false;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsTrue(genos.Position.Y > 0);
        }
        #endregion

        #region Création avec limite 360
        [TestMethod]
        public void TestGenosAleatoire360()
        {
            bool troisSix = true;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsNotNull(genos);
        }

        [TestMethod]
        public void TestGenosPositionAleatoire360()
        {
            bool troisSix = true;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsNotNull(genos.Position);
        }

        [TestMethod]
        public void TestGenosPositionXAleatoire3601()
        {
            bool troisSix = true;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsTrue(genos.Position.X < limite);
        }

        [TestMethod]
        public void TestGenosPositionXAleatoire3602()
        {
            bool troisSix = true;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsTrue(genos.Position.X > -limite);
        }

        [TestMethod]
        public void TestGenosPositionYAleatoire3601()
        {
            bool troisSix = true;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsTrue(genos.Position.Y < limite);
        }

        [TestMethod]
        public void TestGenosPositionYAleatoire3602()
        {
            bool troisSix = true;
            GenosBase genos = new GenosBase(limite, troisSix);
            Assert.IsTrue(genos.Position.Y > -limite);
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
        public void TestSeDeplacerHautDirige()
        {
            Directions direction = new Directions(SensH.NUL, SensV.HAUT);
            genosDeReference.seDeplacer(direction);

            Assert.AreEqual(direction, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerHautDirigeLimite()
        {
            Directions direction = new Directions(SensH.NUL, SensV.HAUT);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(direction, pas, limite);

            Assert.AreEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Haut Droite
        [TestMethod]
        public void TestSeDeplacerHautDroiteDirige()
        {
            Directions direction = new Directions(SensH.DROITE, SensV.HAUT);
            genosDeReference.seDeplacer(direction);

            Assert.AreEqual(direction, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerHautDroiteDirigeLimite()
        {
            Directions direction = new Directions(SensH.DROITE, SensV.HAUT);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(direction, pas, limite);

            Assert.AreEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Droite
        [TestMethod]
        public void TestSeDeplacerDroiteDirige()
        {
            Directions direction = new Directions(SensH.DROITE, SensV.NUL);
            genosDeReference.seDeplacer(direction);

            Assert.AreEqual(direction, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerDroiteDirigeLimite()
        {
            Directions direction = new Directions(SensH.DROITE, SensV.NUL);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(direction, pas, limite);

            Assert.AreEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Bas Droite
        [TestMethod]
        public void TestSeDeplacerBasDroiteDirige()
        {
            Directions direction = new Directions(SensH.DROITE, SensV.BAS);
            genosDeReference.seDeplacer(direction);

            Assert.AreEqual(direction, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerBasDroiteDirigeLimite()
        {
            Directions direction = new Directions(SensH.DROITE, SensV.BAS);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(direction, pas, limite);

            Assert.AreEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Bas
        [TestMethod]
        public void TestSeDeplacerBasDirige()
        {
            Directions direction = new Directions(SensH.NUL, SensV.BAS);
            genosDeReference.seDeplacer(direction);

            Assert.AreEqual(direction, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerBasDirigeLimite()
        {
            Directions direction = new Directions(SensH.NUL, SensV.BAS);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(direction, pas, limite);

            Assert.AreEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Bas Gauche
        [TestMethod]
        public void TestSeDeplacerBasGaucheDirige()
        {
            Directions direction = new Directions(SensH.GAUCHE, SensV.BAS);
            genosDeReference.seDeplacer(direction);

            Assert.AreEqual(direction, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerBasGaucheDirigeLimite()
        {
            Directions direction = new Directions(SensH.GAUCHE, SensV.BAS);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(direction, pas, limite);

            Assert.AreEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Gauche
        [TestMethod]
        public void TestSeDeplacerGaucheDirige()
        {
            Directions direction = new Directions(SensH.GAUCHE, SensV.NUL);
            genosDeReference.seDeplacer(direction);

            Assert.AreEqual(direction, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerGaucheDirigeLimite()
        {
            Directions direction = new Directions(SensH.GAUCHE, SensV.NUL);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(direction, pas, limite);

            Assert.AreEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #region Haut Gauche
        [TestMethod]
        public void TestSeDeplacerHautGaucheDirige()
        {
            Directions direction = new Directions(SensH.GAUCHE, SensV.HAUT);
            genosDeReference.seDeplacer(direction);

            Assert.AreEqual(direction, genosDeReference);
        }
        [TestMethod]
        public void TestSeDeplacerHautGaucheDirigeLimite()
        {
            Directions direction = new Directions(SensH.GAUCHE, SensV.HAUT);
            int pas = 25;
            int limite = 10;
            genosDeReference.seDeplacer(direction, pas, limite);

            Assert.AreEqual(genosTemoin, genosDeReference);
        }
        #endregion

        #endregion
    }
}
