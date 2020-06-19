using System;
using GenosCore.Objets;
using GenosCore.Statics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenosTests.GenosCoreTests.Statics
{
    [TestClass]
    public class DeplacementTests
    {
        Position positionDeReference = new Position();

        #region déplacement horizontal
        [TestMethod]
        public void DeplacementHorizontalDroite()
        {
            Position positionTest = new Position(1, 2);
            positionTest.DeplacementHorizontal(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void DeplacementHorizontalGauche()
        {
            Position positionTest = new Position(3, 2);
            positionTest.DeplacementHorizontal(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void DeplacementHorizontalNul()
        {
            Position positionTest = new Position(2, 2);
            positionTest.DeplacementHorizontal(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }
        #endregion

        #region déplacement vertical
        [TestMethod]
        public void DeplacementVerticalHaut()
        {
            Position positionTest = new Position(2, 3);
            positionTest.DeplacementVertical(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void DeplacementVerticalBas()
        {
            Position positionTest = new Position(2, 1);
            positionTest.DeplacementVertical(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void DeplacementVerticalNul()
        {
            Position positionTest = new Position(2, 2);
            positionTest.DeplacementVertical(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }
        #endregion

        #region déplacement
        [TestMethod]
        public void TestDeplacementFinaleHaut()
        {
            Position positionTest = new Position(2, 3);
            positionTest.Deplacement(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void TestDeplacementFinaleHautDroite()
        {
            Position positionTest = new Position(1, 3);
            positionTest.Deplacement(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void TestDeplacementFinaleDroite()
        {
            Position positionTest = new Position(1, 2);
            positionTest.Deplacement(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void TestDeplacementFinaleBasDroite()
        {
            Position positionTest = new Position(1, 1);
            positionTest.Deplacement(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void TestDeplacementFinaleBas()
        {
            Position positionTest = new Position(2, 1);
            positionTest.Deplacement(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void TestDeplacementFinaleBasGauche()
        {
            Position positionTest = new Position(3, 1);
            positionTest.Deplacement(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void TestDeplacementFinaleGauche()
        {
            Position positionTest = new Position(3, 2);
            positionTest.Deplacement(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }

        [TestMethod]
        public void TestDeplacementFinaleHautGauche()
        {
            Position positionTest = new Position(3, 3);
            positionTest.Deplacement(positionDeReference);

            Assert.AreEqual(positionDeReference, positionTest);
        }
        #endregion
    }
}
