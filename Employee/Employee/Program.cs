using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee("Богдан","Гармата");
            myEmployee.Show();
            Console.ReadKey();
        }
    }
}
