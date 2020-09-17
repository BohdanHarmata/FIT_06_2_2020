using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            User myUser = new User( "Andro",  "Богдан", "Гармата", "18","16.09.2020");
            myUser.Show();
            Console.ReadKey();
        }
    }
}
