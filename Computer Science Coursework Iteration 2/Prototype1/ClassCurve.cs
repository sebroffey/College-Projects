using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;




namespace Prototype1
{
    public class ClassCurve 
    {
        Random rnd = new Random();  //Creates instance of random type.
        
        //Declares the array curvePoints made of Points
        private Point[] curvePoints;
        
        //The start of classCurve
        public ClassCurve()
        {
            //Predefined points that the landscape will pass through.
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 0);
            Point point3 = new Point(0, 0);
            Point point4 = new Point(0, 0);
            Point point5 = new Point(0, 0);
            Point point6 = new Point(0, 0);
            Point point7 = new Point(0, 0);
            //Array containing landscape points.
            curvePoints = new Point[] { point1, point2, point3, point4, point5, point6, point7 };
        }
        //Public funtion to return curvePoints
        public Point[] getPoints()
        {
            return curvePoints;
        }
        //Procedure with paramater graphics and pen which draws the lanscape when called
        public void Draw(Graphics g, Pen pen)
        {
            g.DrawLines(pen, curvePoints);
        }
        //Public procedure to redefine curvePoints
        public void setPoints(Point[] points)
        {
            curvePoints = points;
        }
        public void generateRandom()
        {
            //Random generation of points within set bounds.
            Point point1 = new Point(50, 250);
            Point point2 = new Point(250, rnd.Next(200, 250));
            Point point3 = new Point(450, rnd.Next(200, 250));
            Point point4 = new Point(650, rnd.Next(200, 250));
            Point point5 = new Point(850, rnd.Next(200, 250));
            Point point6 = new Point(1050, rnd.Next(200, 250));
            Point point7 = new Point(1450, 250);
            //New curvePoints created with new points
            curvePoints = new Point[] { point1, point2, point3, point4, point5, point6, point7 };

        }
    }
}
