using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prototype1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Prototype1.Tests
{
    [TestClass()]
    public class UnitTests
    {

        private Point[] curvePoints;

        [TestMethod()]
        public void FreindlyNewLocation()
        {

            Unit instance = new Unit();
            Unit instance2 = new Unit();

            GameModel game = new GameModel();
            Form1 form = new Form1();

            Point point1 = new Point(50, 250);
            Point point2 = new Point(250, 250);
            Point point3 = new Point(650, 450);
            Point point4 = new Point(850, 450);
            Point point5 = new Point(1050, 450);
            Point point6 = new Point(1250, 450);
            Point point7 = new Point(1450, 650);
            curvePoints = new Point[] { point1, point2, point3, point4, point5, point6, point7 };

            Point test = new Point();
            Point correct = new Point();

            instance.unitDefinition(0);
            instance.spawnUnit(curvePoints, form);
            test = instance.newUnitLocation(curvePoints);

            instance2.unitDefinition(0);
            instance2.spawnUnit(curvePoints, form);
            correct.X = Convert.ToInt32(50 + instance2.getSpeed());
            correct.Y = 250 - instance2.getHight();

            if (correct == test)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }



        [TestMethod()]
        public void EnemyNewLocation()
        {
            Unit instance = new Unit();
            Unit instance2 = new Unit();

            GameModel game = new GameModel();
            Form1 form = new Form1();

            Point point1 = new Point(50, 250);
            Point point2 = new Point(250, 450);
            Point point3 = new Point(650, 450);
            Point point4 = new Point(850, 450);
            Point point5 = new Point(1050, 450);
            Point point6 = new Point(1250, 450);
            Point point7 = new Point(1450, 650);
            curvePoints = new Point[] { point1, point2, point3, point4, point5, point6, point7 };

            Point test = new Point();
            Point correct = new Point();

            instance.unitDefinition(1);
            instance.spawnUnit(curvePoints, form);

            test = instance.newUnitLocation(curvePoints);


            instance2.unitDefinition(1);
            instance2.spawnUnit(curvePoints, form);
            correct.X = Convert.ToInt32(1450 + instance2.getSpeed());
            correct.Y = Convert.ToInt32(650 + instance2.getSpeed());


            if (correct == test)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void getAndSetvalidTest()
        {
            //Defult movement valid attribute is set to false
            bool test = false;
            Unit U1 = new Unit();

            U1.setValid(true);
            test = U1.getvalid();

            Assert.AreEqual(test, true);
        }

        [TestMethod()]
        public void getHeightTest()     //Includes unit definition
        {
            //Defult Height set to 0
            int test = 0;
            Unit U1 = new Unit();

            //No set method, height is only changed through
            //unit definition, using test class

            U1.unitDefinition(0);
            //Height is now set to 2

            test = U1.getHight();
            Assert.AreEqual(test, 2);
        }

        [TestMethod()]
        public void getWidthTest()      //Includes unit definition
        {
            //Defult Width set to 0
            int test = 0;
            Unit U1 = new Unit();

            //No set method, Width is only changed through
            //unit definition, using test class

            U1.unitDefinition(0);
            //Width is now set to 3 

            test = U1.getWidth();
            Assert.AreEqual(test, 3);
        }

        [TestMethod()]
        public void getSpeedTest()       //Includes unit definition
        {
            //Defult Speed set to 0
            double test = 0;
            Unit U1 = new Unit();

            //No set method, Speed is only changed through
            //unit definition

            U1.unitDefinition(0);
            //Speed is now set to 1 as test class

            test = U1.getSpeed();
            Assert.AreEqual(test, 1);
        }

        [TestMethod()]
        public void getUnitSpawnTest()
        {
            //Using set method only for testing
            //Defult spawn state is false

            Unit U1 = new Unit();
            U1.setUnitSpawnValue(true);

            bool test = false;
            test = U1.getUnitSpawn();

            Assert.AreEqual(test, true);
        }

        [TestMethod()]
        public void getAndSetUnitArrayPositionTest()
        {
            //Default array position is set to 0

            Unit U1 = new Unit();
            U1.setUnitArrayPosition(2);

            int test = 0;
            test = U1.getUnitArrayPosition();

            Assert.AreEqual(test, 2);
        }

        [TestMethod()]
        public void getUnitLocationTest()
        {
            //Defult unit location is set to (0,0)
            //Using testing methods setUnitUpValue() and setUnitLeftValue()

            Unit U1 = new Unit();
            Point test = new Point(0, 0);
            Point valid = new Point(10, 10);

            U1.setUnitUpValue(10);
            U1.setUnitLeftValue(10);

            test = U1.getUnitLocation();

            Assert.AreEqual(test, valid);
        }

        [TestMethod()]
        public void getUnitRangeTest()
        {
            //Using test class and unit definition
            //Defult range value of unit is 0
            Unit U1 = new Unit();
            int test = 0;

            //Range value set to 4
            U1.unitDefinition(0);
            test = U1.getUnitRange();

            Assert.AreEqual(test, 4);

        }


        [TestMethod()]
        public void getUnitAttackTest()
        {
            //Using test class and unit definition
            //Defult attack value of unit is 0
            Unit U1 = new Unit();
            int test = 0;

            //attack value set to 5
            U1.unitDefinition(0);
            test = U1.getUnitAttack();

            Assert.AreEqual(test, 5);
        }

        [TestMethod()]
        public void getunitAliveTest()
        {
            //Defult value of unit alive is false
            Unit U1 = new Unit();
            bool test = false;

            ////
            U1.setUnitAlive(true);
            test = U1.getunitAlive();

            Assert.AreEqual(test, true);
        }
    }
}