using System;
using GenosCore.Objets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenosTests.GenosCoreTests.Objets
{
    [TestClass]
    public class PositionTests
    {
        Position positionDeReference = new Position();

        #region Creation
        [TestMethod]
        public void PositionTestCreation()
        {
            Position position = new Position();
            Assert.IsNotNull(position);
        }

        [TestMethod]
        public void PositionTestDefautX()
        {
            int x = 2;
            Position position = new Position();
            Assert.AreEqual(x, position.X);
        }

        [TestMethod]
        public void PositionTestDefautY()
        {
            int y = 2;
            Position position = new Position();
            Assert.AreEqual(y, position.Y);
        }

        [TestMethod]
        public void PositionDefinieTestX()
        {

            int x = 5;
            int y = 6;
            Position position = new Position(x, y);
            Assert.AreEqual(x, position.X);
        }

        [TestMethod]
        public void PositionDefinieTestY()
        {

            int x = 5;
            int y = 6;
            Position position = new Position(x, y);
            Assert.AreEqual(y, position.Y);
        }

        [TestMethod]
        public void PositionTestLimiteSimpleXPositif()
        {
            int x = 0;
            int y = 0;
            int limite = 100;
            bool troisSix = false;
            Position position = new Position(limite, troisSix);
            Assert.IsTrue(position.X < limite);
        }

        [TestMethod]
        public void PositionTestLimiteSimpleXNegatif()
        {
            int x = 0;
            int y = 0;
            int limite = 100;
            bool troisSix = false;
            Position position = new Position(limite, troisSix);
            Assert.IsTrue(position.X > x);
        }

        [TestMethod]
        public void PositionTestLimiteSimpleYPositif()
        {
            int x = 0;
            int y = 0;
            int limite = 100;
            bool troisSix = false;
            Position position = new Position(limite, troisSix);
            Assert.IsTrue(position.Y < limite);
        }

        [TestMethod]
        public void PositionTestLimiteSimpleYNegatif()
        {
            int x = 0;
            int y = 0;
            int limite = 100;
            bool troisSix = false;
            Position position = new Position(limite, troisSix);
            Assert.IsTrue(position.Y > y);
        }

        [TestMethod]
        public void PositionTestLimite360()
        {
            int limite = 100;
            bool troisSix = true;
            Position position = new Position(limite, troisSix);
            Assert.AreEqual(limite, position.Limite);
        }

        [TestMethod]
        public void PositionTestLimite360XPositif()
        {
            int limite = 100;
            bool troisSix = true;
            Position position = new Position(limite, troisSix);
            Assert.IsTrue(position.X < limite);
        }

        [TestMethod]
        public void PositionTestLimite360XNegatif()
        {
            int limite = 100;
            bool troisSix = true;
            Position position = new Position(limite, troisSix);
            Assert.IsTrue(position.X > -limite);
        }

        [TestMethod]
        public void PositionTestLimite360YPositif()
        {
            int limite = 100;
            bool troisSix = true;
            Position position = new Position(limite, troisSix);
            Assert.IsTrue(position.Y < limite);
        }

        [TestMethod]
        public void PositionTestLimite360YNegatif()
        {
            int limite = 100;
            bool troisSix = true;
            Position position = new Position(limite, troisSix);
            Assert.IsTrue(position.Y > -limite);
        }

        [TestMethod]
        public void PositionTestDirectionSensH()
        {
            Position position = new Position();
            Assert.AreEqual(SensH.NUL, position.Direction.sensHorizontal);
        }

        [TestMethod]
        public void PositionTestDirectionSensV()
        {
            Position position = new Position();
            Assert.AreEqual(SensV.NUL, position.Direction.sensVertical);
        }

        [TestMethod]
        public void PositionTestDirectionLimiteSensH()
        {
            int limite = 100;
            Position position = new Position(limite);
            Assert.AreEqual(SensH.NUL, position.Direction.sensHorizontal);
        }

        [TestMethod]
        public void PositionTestDirectionLimiteSensV()
        {
            int limite = 100;
            Position position = new Position(limite);
            Assert.AreEqual(SensV.NUL, position.Direction.sensVertical);
        }

        [TestMethod]
        public void PositionTestDirectionPositionSensH()
        {
            int x = 5;
            int y = 6;
            Position position = new Position(x, y);
            Assert.AreEqual(SensH.NUL, position.Direction.sensHorizontal);
        }

        [TestMethod]
        public void PositionTestDirectionPositionSensV()
        {
            int x = 5;
            int y = 6;
            Position position = new Position(x, y);
            Assert.AreEqual(SensV.NUL, position.Direction.sensVertical);
        }
        #endregion

        #region Déplacement horizontal

        #region Droite
        [TestMethod]
        public void PositionTestChangeXDroite()
        {
            Position position = new Position();
            int positionXDepart = position.X;
            SensH p_sens = SensH.DROITE;
            int p_pas = 1;
            int p_limite = 0;
            position.ChangeX(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionXDepart + p_pas, position.X);
        }

        [TestMethod]
        public void PositionTestChangeXLimiteDroite()
        {
            Position position = new Position(9, 0);
            int positionXDepart = position.X;
            SensH p_sens = SensH.DROITE;
            int p_pas = 1;
            int p_limite = 10;
            position.ChangeX(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionXDepart, position.X);
        }

        [TestMethod]
        public void PositionTestChangeXPasDroite()
        {
            Position position = new Position();
            int positionXDepart = position.X;
            SensH p_sens = SensH.DROITE;
            int p_pas = 5;
            int p_limite = 0;
            position.ChangeX(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionXDepart + p_pas, position.X);
        }

        [TestMethod]
        public void PositionTestChangeXLimitePasDroite()
        {
            Position position = new Position(9, 0);
            int positionXDepart = position.X;
            SensH p_sens = SensH.DROITE;
            int p_pas = 5;
            int p_limite = 10;
            position.ChangeX(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionXDepart, position.X);
        }
        #endregion

        #region Gauche
        [TestMethod]
        public void PositionTestChangeXGauche()
        {
            Position position = new Position(5, 0);
            int positionXDepart = position.X;
            SensH p_sens = SensH.GAUCHE;
            int p_pas = 1;
            int p_limite = 0;
            position.ChangeX(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionXDepart - p_pas, position.X);
        }

        [TestMethod]
        public void PositionTestChangeXLimiteGauche()
        {
            Position position = new Position(1, 0);
            int positionXDepart = position.X;
            SensH p_sens = SensH.GAUCHE;
            int p_pas = 1;
            int p_limite = 0;
            position.ChangeX(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionXDepart, position.X);
        }

        [TestMethod]
        public void PositionTestChangeXPasGauche()
        {
            Position position = new Position(6, 0);
            int positionXDepart = position.X;
            SensH p_sens = SensH.GAUCHE;
            int p_pas = 5;
            int p_limite = 0;
            position.ChangeX(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionXDepart - p_pas, position.X);
        }

        [TestMethod]
        public void PositionTestChangeXLimitePasGauche()
        {
            Position position = new Position(2, 0);
            int positionXDepart = position.X;
            SensH p_sens = SensH.GAUCHE;
            int p_pas = 5;
            int p_limite = 0;
            position.ChangeX(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionXDepart, position.X);
        }
        #endregion

        #endregion

        #region Déplacement vertical

        #region Haut
        [TestMethod]
        public void PositionTestChangeYHaut()
        {
            Position position = new Position(0, 2);
            int positionYDepart = position.Y;
            SensV p_sens = SensV.HAUT;
            int p_pas = 1;
            int p_limite = 0;
            position.ChangeY(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionYDepart - p_pas, position.Y);
        }
        [TestMethod]
        public void PositionTestChangeYLimiteHaut()
        {
            Position position = new Position(1, 1);
            int positionYDepart = position.Y;
            SensV p_sens = SensV.HAUT;
            int p_pas = 1;
            int p_limite = 0;
            position.ChangeY(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionYDepart, position.Y);
        }

        [TestMethod]
        public void PositionTestChangeYPasHaut()
        {
            Position position = new Position(0, 8);
            int positionYDepart = position.Y;
            SensV p_sens = SensV.HAUT;
            int p_pas = 5;
            int p_limite = 0;
            position.ChangeY(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionYDepart - p_pas, position.Y);
        }

        [TestMethod]
        public void PositionTestChangeYLimitePasHaut()
        {
            Position position = new Position(0, 3);
            int positionYDepart = position.Y;
            SensV p_sens = SensV.HAUT;
            int p_pas = 5;
            int p_limite = 0;
            position.ChangeY(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionYDepart, position.Y);
        }
        #endregion

        #region Bas
        [TestMethod]
        public void PositionTestChangeYBas()
        {
            Position position = new Position();
            int positionYDepart = position.Y;
            SensV p_sens = SensV.BAS;
            int p_pas = 1;
            int p_limite = 0;
            position.ChangeY(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionYDepart + p_pas, position.Y);
        }

        [TestMethod]
        public void PositionTestChangeYLimiteBas()
        {
            Position position = new Position(1, 9);
            int positionYDepart = position.Y;
            SensV p_sens = SensV.BAS;
            int p_pas = 1;
            int p_limite = 10;
            position.ChangeY(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionYDepart, position.Y);
        }

        [TestMethod]
        public void PositionTestChangeYPasBas()
        {
            Position position = new Position();
            int positionYDepart = position.Y;
            SensV p_sens = SensV.BAS;
            int p_pas = 5;
            int p_limite = 0;
            position.ChangeY(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionYDepart + p_pas, position.Y);
        }

        [TestMethod]
        public void PositionTestChangeYLimitePasBas()
        {
            Position position = new Position(1, 6);
            int positionYDepart = position.Y;
            SensV p_sens = SensV.BAS;
            int p_pas = 5;
            int p_limite = 10;
            position.ChangeY(p_sens, p_pas, p_limite);

            Assert.AreEqual(positionYDepart, position.Y);
        }
        #endregion

        #endregion

        #region Déplacement
        [TestMethod]
        public void PositionTestChangePositionAleatoire()
        {
            Position position1 = new Position();

            Random rand = new Random();
            SensH sensHorizontal = SensH.NUL;
            SensV sensVertical = SensV.NUL;

            int horizontal = rand.Next(3);
            int vertical = rand.Next(3);

            switch (horizontal)
            {
                case 1:
                    sensHorizontal = SensH.DROITE;
                    break;
                case 2:
                    sensHorizontal = SensH.GAUCHE;
                    break;
            }

            switch (vertical)
            {
                case 1:
                    sensVertical = SensV.HAUT;
                    break;
                case 2:
                    sensVertical = SensV.BAS;
                    break;
            }

            int p_pas = 1;
            int p_limite = 0;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);

            Position positionDeReference = new Position();

            if (sensHorizontal == SensH.NUL && sensVertical == SensV.NUL)
            {
                Assert.AreEqual(positionDeReference, position1);
            }
            else
            {
                Assert.AreNotEqual(positionDeReference, position1);
            }
        }

        [TestMethod]
        public void PositionTestChangePositionLimiteAleatoire()
        {
            Position position1 = new Position();

            Random rand = new Random();
            SensH sensHorizontal = SensH.NUL;
            SensV sensVertical = SensV.NUL;

            int horizontal = rand.Next(3);
            int vertical = rand.Next(3);

            switch (horizontal)
            {
                case 1:
                    sensHorizontal = SensH.DROITE;
                    break;
                case 2:
                    sensHorizontal = SensH.GAUCHE;
                    break;
            }

            switch (vertical)
            {
                case 1:
                    sensVertical = SensV.HAUT;
                    break;
                case 2:
                    sensVertical = SensV.BAS;
                    break;
            }

            int p_pas = 30;
            int p_limite = 10;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);

            Position positionDeReference = new Position();

            Assert.AreEqual(positionDeReference, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionHaut()
        {
            Position position1 = new Position(2, 3);

            Random rand = new Random();
            SensH sensHorizontal = SensH.NUL;
            SensV sensVertical = SensV.HAUT;

            int p_pas = 1;
            int p_limite = 0;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(positionDeReference, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionLimiteHaut()
        {
            Position position1 = new Position(2, 3);
            Position position2 = new Position(2, 3);

            Random rand = new Random();
            SensH sensHorizontal = SensH.NUL;
            SensV sensVertical = SensV.HAUT;

            int p_pas = 25;
            int p_limite = 10;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(position2, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionHautDroite()
        {
            Position position1 = new Position(1, 3);

            Random rand = new Random();
            SensH sensHorizontal = SensH.DROITE;
            SensV sensVertical = SensV.HAUT;

            int p_pas = 1;
            int p_limite = 0;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(positionDeReference, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionLimiteHautDroite()
        {
            Position position1 = new Position(1, 3);
            Position position2 = new Position(1, 3);

            Random rand = new Random();
            SensH sensHorizontal = SensH.DROITE;
            SensV sensVertical = SensV.HAUT;

            int p_pas = 25;
            int p_limite = 10;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(position2, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionDroite()
        {
            Position position1 = new Position(1, 2);

            Random rand = new Random();
            SensH sensHorizontal = SensH.DROITE;
            SensV sensVertical = SensV.NUL;

            int p_pas = 1;
            int p_limite = 0;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);

            Assert.AreEqual(positionDeReference, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionLimiteDroite()
        {
            Position position1 = new Position(1, 2);
            Position position2 = new Position(1, 2);

            Random rand = new Random();
            SensH sensHorizontal = SensH.DROITE;
            SensV sensVertical = SensV.NUL;

            int p_pas = 25;
            int p_limite = 10;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(position2, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionBasDroite()
        {
            Position position1 = new Position(1, 1);

            Random rand = new Random();
            SensH sensHorizontal = SensH.DROITE;
            SensV sensVertical = SensV.BAS;

            int p_pas = 1;
            int p_limite = 0;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(positionDeReference, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionLimiteBasDroite()
        {
            Position position1 = new Position(1, 1);
            Position position2 = new Position(1, 1);

            Random rand = new Random();
            SensH sensHorizontal = SensH.DROITE;
            SensV sensVertical = SensV.BAS;

            int p_pas = 25;
            int p_limite = 10;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(position2, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionBas()
        {
            Position position1 = new Position(2, 1);

            Random rand = new Random();
            SensH sensHorizontal = SensH.NUL;
            SensV sensVertical = SensV.BAS;

            int p_pas = 1;
            int p_limite = 0;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(positionDeReference, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionLimiteBas()
        {
            Position position1 = new Position(2, 1);
            Position position2 = new Position(2, 1);

            Random rand = new Random();
            SensH sensHorizontal = SensH.NUL;
            SensV sensVertical = SensV.BAS;

            int p_pas = 25;
            int p_limite = 10;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(position2, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionBasGauche()
        {
            Position position1 = new Position(3, 1);

            Random rand = new Random();
            SensH sensHorizontal = SensH.GAUCHE;
            SensV sensVertical = SensV.BAS;

            int p_pas = 1;
            int p_limite = 0;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(positionDeReference, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionLimiteBasGauche()
        {
            Position position1 = new Position(3, 1);
            Position position2 = new Position(3, 1);

            Random rand = new Random();
            SensH sensHorizontal = SensH.GAUCHE;
            SensV sensVertical = SensV.BAS;

            int p_pas = 25;
            int p_limite = 10;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(position2, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionGauche()
        {
            Position position1 = new Position(3, 2);

            Random rand = new Random();
            SensH sensHorizontal = SensH.GAUCHE;
            SensV sensVertical = SensV.NUL;

            int p_pas = 1;
            int p_limite = 0;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(positionDeReference, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionLimiteGauche()
        {
            Position position1 = new Position(3, 2);
            Position position2 = new Position(3, 2);

            Random rand = new Random();
            SensH sensHorizontal = SensH.GAUCHE;
            SensV sensVertical = SensV.NUL;

            int p_pas = 25;
            int p_limite = 10;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(position2, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionHautGauche()
        {
            Position position1 = new Position(3, 3);

            Random rand = new Random();
            SensH sensHorizontal = SensH.GAUCHE;
            SensV sensVertical = SensV.HAUT;

            int p_pas = 1;
            int p_limite = 0;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);


            Assert.AreEqual(positionDeReference, position1);
        }

        [TestMethod]
        public void PositionTestChangePositionLimiteHautGauche()
        {
            Position position1 = new Position(3, 3);
            Position position2 = new Position(3, 3);

            Random rand = new Random();
            SensH sensHorizontal = SensH.GAUCHE;
            SensV sensVertical = SensV.HAUT;

            int p_pas = 25;
            int p_limite = 10;
            Directions direction = new Directions(sensHorizontal, sensVertical);
            position1.ChangePosition(direction, p_pas, p_limite);

            Assert.AreEqual(position2, position1);
        }
        #endregion
    }
}
