using System;
using GenosCore.Objets;
using GenosCore.Statics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenosTests.GenosCoreTests.Statics
{
    [TestClass]
    public class TrigonometrieTests
    {
        Position positionDeReference = new Position();
        Position position = new Position(5, 6);

        [TestMethod]
        public void TestCalculerAngle1()
        {
            int cote1 = 3;
            int coteHypotenuse = 5;

            double anglePrevu = Math.Acos(cote1 / coteHypotenuse);

            double angleTest = Trigonometrie.CalculerAngle(cote1, coteHypotenuse);

            Assert.AreEqual(anglePrevu, angleTest);
        }

        [TestMethod]
        public void TestCalculerAngle2()
        {
            int cote1 = 4;
            int coteHypotenuse = 5;

            double anglePrevu = Math.Acos(cote1 / coteHypotenuse);

            double angleTest = Trigonometrie.CalculerAngle(cote1, coteHypotenuse);

            Assert.AreEqual(anglePrevu, angleTest);
        }

        [TestMethod]
        public void TestAngle1()
        {
            int cote1 = 3;
            int coteHypotenuse = 5;

            double anglePrevu = Math.Acos(cote1 / coteHypotenuse);

            double angleTest = positionDeReference.Angle(position);

            Assert.AreEqual(anglePrevu, angleTest);
        }

        [TestMethod]
        public void TestAngle2()
        {
            int cote1 = 4;
            int coteHypotenuse = 5;

            double anglePrevu = Math.Acos(cote1 / coteHypotenuse);

            double angleTest = positionDeReference.Angle(position);

            Assert.AreEqual(anglePrevu, angleTest);
        }
    }
}
