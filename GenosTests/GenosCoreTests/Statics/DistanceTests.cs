using System;
using GenosCore.Objets;
using GenosCore.Statics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenosTests.GenosCoreTests.Statics
{
    [TestClass]
    public class DistanceTests
    {
        Position positionDeReference = new Position(0, 0);
        Position positionTest = new Position(3, 4);
        GenosBase genosDeReference = new GenosBase(0, 0);
        GenosBase genosTest = new GenosBase(3, 4);

        #region ECART

        #region écart horizontal
        [TestMethod]
        public void TestEcartXDroite()
        {
            int ecartX = positionDeReference.EcartX(positionTest);

            Assert.AreEqual(positionTest.X - positionDeReference.X, ecartX);
        }

        [TestMethod]
        public void TestEcartXGauche()
        {
            int ecartX = positionTest.EcartX(positionDeReference);

            Assert.AreEqual(-(positionTest.X - positionDeReference.X), ecartX);
        }

        [TestMethod]
        public void TestEcartHorizontalDroite()
        {
            Position positionTest1 = new Position(5, 0);

            double ecart = positionDeReference.Ecart(positionTest1);

            Assert.AreEqual(positionTest1.X - positionDeReference.X, ecart);
        }

        [TestMethod]
        public void TestEcartHorizontalGauche()
        {
            Position positionTest1 = new Position(5, 0);

            double ecart = positionTest1.Ecart(positionDeReference);

            Assert.AreEqual(-(positionTest1.X - positionDeReference.X), ecart);
        }
        #endregion

        #region écart vertical
        [TestMethod]
        public void TestEcartYBas()
        {
            int ecartY = positionDeReference.EcartY(positionTest);

            Assert.AreEqual(positionTest.Y - positionDeReference.Y, ecartY);
        }

        [TestMethod]
        public void TestEcartYHaut()
        {
            int ecartY = positionTest.EcartY(positionDeReference);

            Assert.AreEqual(-(positionTest.Y - positionDeReference.Y), ecartY);
        }

        [TestMethod]
        public void TestEcartVerticalBas()
        {
            Position positionTest1 = new Position(0, 5);

            double ecart = positionDeReference.Ecart(positionTest1);

            Assert.AreEqual(positionTest1.X - positionDeReference.X, ecart);
        }

        [TestMethod]
        public void TestEcartVerticalHaut()
        {
            Position positionTest1 = new Position(0, 5);

            double ecart = positionTest1.Ecart(positionDeReference);

            Assert.AreEqual(-(positionTest1.X - positionDeReference.X), ecart);
        }
        #endregion

        #region écart
        [TestMethod]
        public void TestEcartPositif()
        {
            double ecart1 = positionDeReference.Ecart(positionTest);

            Assert.AreEqual(5, ecart1);
        }
        [TestMethod]
        public void TestEcartNegatif()
        {
            double ecart1 = positionTest.Ecart(positionDeReference);

            Assert.AreEqual(5, ecart1);
        }
        #endregion

        #endregion

        #region CLASSEMENT

        #region POSITION

        #region le plus proche
        [TestMethod]
        public void TestPlusProchePosition1()
        {
            Position position1 = new Position(10, 8);
            Position[] tableau = new Position[2];

            tableau[0] = positionTest;
            tableau[1] = position1;

            Position positionPlusProche = positionDeReference.PlusProchePosition(tableau);

            Assert.AreEqual(positionTest, positionPlusProche);
        }

        [TestMethod]
        public void TestPlusProchePosition2()
        {
            Position position1 = new Position(10, 8);
            Position position2 = new Position(12, 1);
            Position position3 = new Position(5, 6);
            Position[] tableau = new Position[3];

            tableau[0] = position1;
            tableau[1] = position2;
            tableau[2] = position3;

            Position positionPlusProche = positionDeReference.PlusProchePosition(tableau);

            Assert.AreEqual(position3, positionPlusProche);
        }
        #endregion

        #region le plus loin
        [TestMethod]
        public void TestPlusLointainePosition1()
        {
            Position position1 = new Position(10, 8);
            Position[] tableau = new Position[2];

            tableau[0] = positionTest;
            tableau[1] = position1;

            Position positionPlusLoin = positionDeReference.PlusLointainePosition(tableau);

            Assert.AreEqual(position1, positionPlusLoin);
        }

        [TestMethod]
        public void TestPlusLointainePosition2()
        {
            Position position1 = new Position(10, 8);
            Position position2 = new Position(12, 1);
            Position position3 = new Position(5, 6);
            Position[] tableau = new Position[3];

            tableau[0] = position1;
            tableau[1] = position2;
            tableau[2] = position3;

            Position positionPlusLoin = positionDeReference.PlusLointainePosition(tableau);

            Assert.AreEqual(position1, positionPlusLoin);
        }
        #endregion

        #region ordre croissant
        [TestMethod]
        public void TestPositionCroissante()
        {
            Position position1 = new Position(10, 8);
            Position position2 = new Position(12, 1);
            Position position3 = new Position(5, 6);
            Position[] tableau = new Position[3];
            Position[] tableauDeReference = new Position[3];

            tableau[0] = position1;
            tableau[1] = position2;
            tableau[2] = position3;

            tableauDeReference[0] = position3;
            tableauDeReference[1] = position2;
            tableauDeReference[2] = position1;

            Position[] positionPlusLoin = positionDeReference.PositionsCroissantes(tableau);

            for (int i = 0; i < positionPlusLoin.Length; i++)
            {
                Assert.AreEqual(positionPlusLoin[i], tableauDeReference);
            }
        }
        #endregion

        #region ordre décroissant
        [TestMethod]
        public void TestPositionsDecroissantes()
        {
            Position position1 = new Position(12, 1);
            Position position2 = new Position(10, 8);
            Position position3 = new Position(5, 6);
            Position[] tableau = new Position[3];
            Position[] tableauDeReference = new Position[3];

            tableau[0] = position1;
            tableau[1] = position2;
            tableau[2] = position3;

            tableauDeReference[0] = position2;
            tableauDeReference[1] = position1;
            tableauDeReference[2] = position3;

            Position[] positionPlusLoin = positionDeReference.PositionsDecroissantes(tableau);

            for (int i = 0; i < positionPlusLoin.Length; i++)
            {
                Assert.AreEqual(positionPlusLoin[i], tableauDeReference);
            }
        }
        #endregion

        #endregion

        #region GENOS

        #region le plus proche
        [TestMethod]
        public void TestPlusProcheGenos1()
        {
            GenosBase genos1 = new GenosBase(10, 8);
            GenosBase[] tableau = new GenosBase[2];

            tableau[0] = genosTest;
            tableau[1] = genos1;

            GenosBase genosPlusProche = genosDeReference.PlusProcheGenos(tableau);

            Assert.AreEqual(genosTest, genosPlusProche);
        }

        [TestMethod]
        public void TestPlusProcheGenos2()
        {
            GenosBase genos1 = new GenosBase(10, 8);
            GenosBase genos2 = new GenosBase(12, 1);
            GenosBase genos3 = new GenosBase(5, 6);
            GenosBase[] tableau = new GenosBase[3];

            tableau[0] = genos1;
            tableau[1] = genos2;
            tableau[2] = genos3;

            GenosBase genosPlusProche = genosDeReference.PlusProcheGenos(tableau);

            Assert.AreEqual(genos3, genosPlusProche);
        }
        #endregion

        #region le plus loin
        [TestMethod]
        public void TestPlusLointaineGenos1()
        {
            GenosBase genos1 = new GenosBase(10, 8);
            GenosBase[] tableau = new GenosBase[2];

            tableau[0] = genosTest;
            tableau[1] = genos1;

            GenosBase genosPlusLoin = genosDeReference.PlusLointainGenos(tableau);

            Assert.AreEqual(genos1, genosPlusLoin);
        }

        [TestMethod]
        public void TestPlusLointaineGenos2()
        {
            GenosBase genos1 = new GenosBase(10, 8);
            GenosBase genos2 = new GenosBase(12, 1);
            GenosBase genos3 = new GenosBase(5, 6);
            GenosBase[] tableau = new GenosBase[3];

            tableau[0] = genos1;
            tableau[1] = genos2;
            tableau[2] = genos3;

            GenosBase genosPlusLoin = genosDeReference.PlusLointainGenos(tableau);

            Assert.AreEqual(genos1, genosPlusLoin);
        }
        #endregion

        #region ordre croissant
        [TestMethod]
        public void TestGenosCroissants()
        {
            GenosBase genos1 = new GenosBase(10, 8);
            GenosBase genos2 = new GenosBase(12, 1);
            GenosBase genos3 = new GenosBase(5, 6);
            GenosBase[] tableau = new GenosBase[3];
            GenosBase[] tableauDeReference = new GenosBase[3];

            tableau[0] = genos1;
            tableau[1] = genos2;
            tableau[2] = genos3;

            tableauDeReference[0] = genos3;
            tableauDeReference[1] = genos2;
            tableauDeReference[2] = genos1;

            GenosBase[] genosPlusLoin = genosDeReference.GenosCroissants(tableau);

            for (int i = 0; i < genosPlusLoin.Length; i++)
            {
                Assert.AreEqual(genosPlusLoin[i], tableauDeReference);
            }
        }
        #endregion

        #region ordre décroissant
        [TestMethod]
        public void TestGenosDecroissants()
        {
            GenosBase genos1 = new GenosBase(12, 1);
            GenosBase genos2 = new GenosBase(10, 8);
            GenosBase genos3 = new GenosBase(5, 6);
            GenosBase[] tableau = new GenosBase[3];
            GenosBase[] tableauDeReference = new GenosBase[3];

            tableau[0] = genos1;
            tableau[1] = genos2;
            tableau[2] = genos3;

            tableauDeReference[0] = genos2;
            tableauDeReference[1] = genos1;
            tableauDeReference[2] = genos3;

            GenosBase[] genosPlusLoin = genosDeReference.GenosDecroissants(tableau);

            for (int i = 0; i < genosPlusLoin.Length; i++)
            {
                Assert.AreEqual(genosPlusLoin[i], tableauDeReference);
            }
        }
        #endregion

        #endregion

        #endregion

    }
}
