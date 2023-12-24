using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    //Calculate Area of Plane Shapes
    static internal class CalculateShapeArea
    {
        public static double Square(double a)
        {
            //Console.WriteLine("You have choicen a Square");
            return a * a;
        }
        public static double Rectangle(double w, double h)
        {
            //Console.WriteLine("You have choicen a Rectangle");
            return w * h;
        }
        public static double Triangle(double b, double h)
        {
            //Console.WriteLine("You have choicen a Triangle");
            return 0.5 * b * h;
        }
        public static double Diamond(double D, double d)
        {
            //Console.WriteLine("You have choicen a Diamond");
            return 0.5 * D * d;
        }
        public static double Trapezoid(double a, double b, double h)
        {
            //Console.WriteLine("You have choicen a Trapezoid");
            return 0.5*(a + b) * h;
        }
        public static double Circle(double r)
        {
            //Console.WriteLine("You have choicen a Circle");
            return Math.PI * r * r;
        }

    }
}
