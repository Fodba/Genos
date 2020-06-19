using System;
using GenosCore.Objets;
using GenosCore.Statics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenosTests.GenosCoreTests.Statics
{
    [TestClass]
    public class DirectionTests
    {
        Position positionDeReference = new Position();

        #region sens horizontal
        [TestMethod]
        public void TestSensHorizontalDroite()
        {
            Position positionTest = new Position(5, 2);
            SensH sensHorizontal = positionDeReference.SensHorizontal(positionTest);

            Assert.AreEqual(SensH.DROITE, sensHorizontal);
        }

        [TestMethod]
        public void TestSensHorizontalGauche()
        {
            Position positionTest = new Position(-5, 2);
            SensH sensHorizontal = positionDeReference.SensHorizontal(positionTest);

            Assert.AreEqual(SensH.GAUCHE, sensHorizontal);
        }

        [TestMethod]
        public void TestSensHorizontalNul()
        {
            Position positionTest = new Position();
            SensH sensHorizontal = positionDeReference.SensHorizontal(positionTest);

            Assert.AreEqual(SensH.NUL, sensHorizontal);
        }
        #endregion

        #region sens vertical
        [TestMethod]
        public void TestSensVerticalBas()
        {
            Position positionTest = new Position(2, 5);
            SensV sensHorizontal = positionDeReference.SensVertical(positionTest);

            Assert.AreEqual(SensV.BAS, sensHorizontal);
        }

        [TestMethod]
        public void TestSensVerticalHaut()
        {
            Position positionTest = new Position(2, -5);
            SensV sensHorizontal = positionDeReference.SensVertical(positionTest);

            Assert.AreEqual(SensV.HAUT, sensHorizontal);
        }

        [TestMethod]
        public void TestSensVerticalNul()
        {
            Position positionTest = new Position();
            SensV sensHorizontal = positionDeReference.SensVertical(positionTest);

            Assert.AreEqual(SensV.NUL, sensHorizontal);
        }
        #endregion

        #region direction finale
        [TestMethod]
        public void TestDirectionFinaleHaut()
        {
            Position positionTest = new Position(2, -3);
            Directions directionDeReference = new Directions(SensH.NUL, SensV.HAUT);
            Directions directionTest = positionDeReference.DirectionFinale(positionTest);

            Assert.AreEqual(directionDeReference, directionTest);
        }

        [TestMethod]
        public void TestDirectionFinaleHautDroite()
        {
            Position positionTest = new Position(7, -3);
            Directions directionDeReference = new Directions(SensH.DROITE, SensV.HAUT);
            Directions directionTest = positionDeReference.DirectionFinale(positionTest);

            Assert.AreEqual(directionDeReference, directionTest);
        }

        [TestMethod]
        public void TestDirectionFinaleDroite()
        {
            Position positionTest = new Position(7, 2);
            Directions directionDeReference = new Directions(SensH.DROITE, SensV.NUL);
            Directions directionTest = positionDeReference.DirectionFinale(positionTest);

            Assert.AreEqual(directionDeReference, directionTest);
        }

        [TestMethod]
        public void TestDirectionFinaleBasDroite()
        {
            Position positionTest = new Position(7, 7);
            Directions directionDeReference = new Directions(SensH.DROITE, SensV.BAS);
            Directions directionTest = positionDeReference.DirectionFinale(positionTest);

            Assert.AreEqual(directionDeReference, directionTest);
        }

        [TestMethod]
        public void TestDirectionFinaleBas()
        {
            Position positionTest = new Position(2, 7);
            Directions directionDeReference = new Directions(SensH.NUL, SensV.BAS);
            Directions directionTest = positionDeReference.DirectionFinale(positionTest);

            Assert.AreEqual(directionDeReference, directionTest);
        }

        [TestMethod]
        public void TestDirectionFinaleBasGauche()
        {
            Position positionTest = new Position(-3, 7);
            Directions directionDeReference = new Directions(SensH.GAUCHE, SensV.BAS);
            Directions directionTest = positionDeReference.DirectionFinale(positionTest);

            Assert.AreEqual(directionDeReference, directionTest);
        }

        [TestMethod]
        public void TestDirectionFinaleGauche()
        {
            Position positionTest = new Position(-3, 2);
            Directions directionDeReference = new Directions(SensH.GAUCHE, SensV.NUL);
            Directions directionTest = positionDeReference.DirectionFinale(positionTest);

            Assert.AreEqual(directionDeReference, directionTest);
        }

        [TestMethod]
        public void TestDirectionFinaleHautGauche()
        {
            Position positionTest = new Position(-3, -3);
            Directions directionDeReference = new Directions(SensH.GAUCHE, SensV.HAUT);
            Directions directionTest = positionDeReference.DirectionFinale(positionTest);

            Assert.AreEqual(directionDeReference, directionTest);
        }

        [TestMethod]
        public void TestDirectionAleatoireTrue()
        {
            bool aleatoire = true;
            Directions direction = new Directions(aleatoire);
            Assert.IsNotNull(direction);
        }

        [TestMethod]
        public void TestDirectionAleatoireFalse()
        {
            bool aleatoire = false;
            Directions direction = new Directions(aleatoire);
            Assert.IsNotNull(direction);
        }
        #endregion
    }
}
