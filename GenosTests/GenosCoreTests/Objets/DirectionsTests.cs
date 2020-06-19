using System;
using GenosCore.Objets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenosTests.GenosCoreTests.Objets
{
    [TestClass]
    public class DirectionsTests
    {
        SensH sensHorizontal;
        SensV sensVertical;

        #region Création Directions
        [TestMethod]
        public void DirectionsTestCreationHorizontal()
        {
            sensHorizontal = SensH.NUL;

            Directions direction = new Directions();
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }
        [TestMethod]
        public void DirectionsTestCreationVertical()
        {
            sensVertical = SensV.NUL;

            Directions direction = new Directions();
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }
        #endregion

        #region Direction Horizontal
        [TestMethod]
        public void DirectionsTestHorizontalNul()
        {
            sensHorizontal = SensH.NUL;

            Directions direction = new Directions(sensHorizontal);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }

        [TestMethod]
        public void DirectionsTestHorizontalDroite()
        {
            sensHorizontal = SensH.DROITE;

            Directions direction = new Directions(sensHorizontal);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }

        [TestMethod]
        public void DirectionsTestHorizontalGauche()
        {
            sensHorizontal = SensH.GAUCHE;

            Directions direction = new Directions(sensHorizontal);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }

        [TestMethod]
        public void DirectionsTestHorizontalAleatoire()
        {
            Random r = new Random();

            sensHorizontal = SensH.NUL;

            switch (r.Next(3))
            {
                case 1:
                    sensHorizontal = SensH.DROITE;
                    break;
                case 2:
                    sensHorizontal = SensH.GAUCHE;
                    break;
            }

            Directions direction = new Directions(sensHorizontal);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }
        #endregion

        #region Directions Vertical
        [TestMethod]
        public void DirectionsTestVerticalNul()
        {
            sensHorizontal = SensH.NUL;
            sensVertical = SensV.NUL;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }

        [TestMethod]
        public void DirectionsTestVerticalHaut()
        {
            sensHorizontal = SensH.NUL;
            sensVertical = SensV.HAUT;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }

        [TestMethod]
        public void DirectionsTestVerticalBas()
        {
            sensHorizontal = SensH.NUL;
            sensVertical = SensV.BAS;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }

        [TestMethod]
        public void DirectionsTestVerticalAleatoire()
        {
            Random r = new Random();

            sensHorizontal = SensH.NUL;
            sensVertical = SensV.NUL;

            switch (r.Next(3))
            {
                case 1:
                    sensVertical = SensV.HAUT;
                    break;
                case 2:
                    sensVertical = SensV.BAS;
                    break;
            }

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }
        #endregion

        #region Directions
        [TestMethod]
        public void DirectionsTestTousHorizontal()
        {
            Random rand = new Random();
            int horizontal = rand.Next(3);

            sensHorizontal = SensH.NUL;

            switch (horizontal)
            {
                case 1:
                    sensHorizontal = SensH.DROITE;
                    break;
                case 2:
                    sensHorizontal = SensH.GAUCHE;
                    break;
            }

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }
        [TestMethod]
        public void DirectionsTestTous()
        {
            Random rand = new Random();
            int vertical = rand.Next(3);

            sensVertical = SensV.NUL;

            switch (vertical)
            {
                case 1:
                    sensVertical = SensV.HAUT;
                    break;
                case 2:
                    sensVertical = SensV.BAS;
                    break;
            }

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }

        [TestMethod]
        public void DirectionsTestDirectionHautHorizontal()
        {
            Random rand = new Random();

            sensVertical = SensV.HAUT;
            sensHorizontal = SensH.NUL;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }
        [TestMethod]
        public void DirectionsTestDirectionHautVertical()
        {
            Random rand = new Random();

            sensVertical = SensV.HAUT;
            sensHorizontal = SensH.NUL;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }

        [TestMethod]
        public void DirectionsTestDirectionHautDroiteHorizontal()
        {
            Random rand = new Random();

            sensVertical = SensV.HAUT;
            sensHorizontal = SensH.DROITE;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }
        [TestMethod]
        public void DirectionsTestDirectionHautDroiteVertical()
        {
            Random rand = new Random();

            sensVertical = SensV.HAUT;
            sensHorizontal = SensH.DROITE;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }

        [TestMethod]
        public void DirectionsTestDirectionDroiteHorizontal()
        {
            Random rand = new Random();

            sensVertical = SensV.NUL;
            sensHorizontal = SensH.DROITE;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }
        [TestMethod]
        public void DirectionsTestDirectionDroiteVertical()
        {
            Random rand = new Random();

            sensVertical = SensV.NUL;
            sensHorizontal = SensH.DROITE;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }

        [TestMethod]
        public void DirectionsTestDirectionBasDroiteHorizontal()
        {
            Random rand = new Random();

            sensVertical = SensV.BAS;
            sensHorizontal = SensH.DROITE;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }
        [TestMethod]
        public void DirectionsTestDirectionBasDroiteVertical()
        {
            Random rand = new Random();

            sensVertical = SensV.BAS;
            sensHorizontal = SensH.DROITE;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }

        [TestMethod]
        public void DirectionsTestDirectionBasHorizontal()
        {
            Random rand = new Random();

            sensVertical = SensV.BAS;
            sensHorizontal = SensH.NUL;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }
        [TestMethod]
        public void DirectionsTestDirectionBasVertical()
        {
            Random rand = new Random();

            sensVertical = SensV.BAS;
            sensHorizontal = SensH.NUL;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }

        [TestMethod]
        public void DirectionsTestDirectionBasGaucheHorizontal()
        {
            Random rand = new Random();

            sensVertical = SensV.BAS;
            sensHorizontal = SensH.GAUCHE;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }
        [TestMethod]
        public void DirectionsTestDirectionBasGaucheVertical()
        {
            Random rand = new Random();

            sensVertical = SensV.BAS;
            sensHorizontal = SensH.GAUCHE;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }

        [TestMethod]
        public void DirectionsTestDirectionGaucheHorizontal()
        {
            Random rand = new Random();

            sensVertical = SensV.NUL;
            sensHorizontal = SensH.GAUCHE;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensHorizontal, direction.sensHorizontal);
        }

        [TestMethod]
        public void DirectionsTestDirectionHautGaucheVertical()
        {
            Random rand = new Random();

            sensVertical = SensV.HAUT;
            sensHorizontal = SensH.GAUCHE;

            Directions direction = new Directions(sensHorizontal, sensVertical);
            Assert.AreEqual(sensVertical, direction.sensVertical);
        }
        #endregion
    }
}
