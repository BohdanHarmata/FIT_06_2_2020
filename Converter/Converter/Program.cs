using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter myConverter = new Converter(Convert.ToDouble(Console.ReadLine()));
            myConverter.Show();
            Console.ReadKey();

        }
    }
}
