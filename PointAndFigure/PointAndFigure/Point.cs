using System;
using System.Collections.Generic;
using System.Text;

namespace PointAndFigure
{
class Point
    {
        string name;
        int x, y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Введіть букву вершини:");
            this.name = Console.ReadLine();
            Console.WriteLine("Введіть X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }
}


