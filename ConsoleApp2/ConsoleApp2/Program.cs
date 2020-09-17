using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle(Convert.ToDouble(Console.ReadLine()),Convert.ToDouble((Console.ReadLine())));
            myRectangle.RectangleOut();
            Console.ReadKey();
        }
    }
}
