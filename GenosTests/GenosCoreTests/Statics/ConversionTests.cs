using System;
using GenosCore.Objets;
using GenosCore.Statics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenosTests.GenosCoreTests.Statics
{
    [TestClass]
    public class ConversionTests
    {
        [TestMethod]
        public void StringToPositionTestVirgule()
        {
            Position positionDeReference = new Position(5, 3);
            string stringPosition1 = "5,3";

            Position positionTest1 = stringPosition1.StringToPosition();

            Assert.AreEqual(positionDeReference, positionTest1);
        }

        [TestMethod]
        public void StringToPositionTestPoint()
        {
            Position positionDeReference = new Position(5, 3);
            string stringPosition1 = "5.3";

            Position positionTest1 = stringPosition1.StringToPosition();

            Assert.AreEqual(positionDeReference, positionTest1);
        }

        [TestMethod]
        public void IsPositionTest1()
        {
            string stringPosition1 = "5,3";

            Assert.IsTrue(stringPosition1.IsPosition());
        }

        [TestMethod]
        public void IsPositionTest2()
        {
            string stringPosition1 = "5.3";

            Assert.IsTrue(stringPosition1.IsPosition());
        }

        [TestMethod]
        public void IsPositionTest3()
        {
            string stringPosition3 = "mlk";

            Assert.IsFalse(stringPosition3.IsPosition());
        }

        [TestMethod]
        public void IsPositionTest4()
        {
            string stringPosition4 = "5?3";

            Assert.IsFalse(stringPosition4.IsPosition());
        }

        [TestMethod]
        public void IsPositionTest5()
        {
            string stringPosition5 = "5,3,2";

            Assert.IsFalse(stringPosition5.IsPosition());
        }

        [TestMethod]
        public void IsPositionTest6()
        {
            string stringPosition6 = "..";

            Assert.IsFalse(stringPosition6.IsPosition());
        }

        [TestMethod]
        public void IsPositionTest7()
        {
            string stringPosition7 = ",,";

            Assert.IsFalse(stringPosition7.IsPosition());
        }
    }
}

