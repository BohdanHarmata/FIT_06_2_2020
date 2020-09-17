using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Rectangle
    {
        private double side1 { get; set; }
        private double side2 { get; set; }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator(double side1, double side2)
        {
            double Area = side1 * side2;
            return Area;
        }
        public double PerimeterCalculator(double side1, double side2)
        {
            double Perimeter = 2 * side1 + 2 * side2;
            return Perimeter;
        }
        public void RectangleOut()
        {
            Console.WriteLine($"Side1 {side1}");
            Console.WriteLine($"Side2 {side2}");
            Console.WriteLine($"Area {AreaCalculator(side1,side2)}");
            Console.WriteLine($"Perimeter {PerimeterCalculator(side1, side2)}");
        }


    }
}
