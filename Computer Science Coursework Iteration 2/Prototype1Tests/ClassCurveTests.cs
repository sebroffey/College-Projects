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
    public class ClassCurveTests
    {
        private Point[] testPoints;
        private Point[] getTestPoints;
        [TestMethod()]
        public void setPointsTest()
        {

            ClassCurve curve = new ClassCurve();
            Point point1 = new Point(50, 250);
            Point point2 = new Point(250, 220);
            Point point3 = new Point(650, 220);
            Point point4 = new Point(850, 250);
            Point point5 = new Point(1050, 230);
            Point point6 = new Point(1250, 220);
            Point point7 = new Point(1450, 250);
            testPoints = new Point[] { point1, point2, point3, point4, point5, point6, point7 };
            curve.setPoints(testPoints);

            Assert.AreEqual(curve.getPoints(), testPoints);
        }

       

    }
}