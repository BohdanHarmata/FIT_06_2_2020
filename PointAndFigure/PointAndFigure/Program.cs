using System;

namespace PointAndFigure
{
    class Program
    {
        static void Main(string[] args)
        {

                Figure cube = new Figure("Куб");
                Console.WriteLine(cube.CalculatePerimeter());
                Console.ReadKey();
            }
        }
    }

