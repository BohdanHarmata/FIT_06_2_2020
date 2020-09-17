using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Addres myAddres = new Addres(07400,"Ukraine","Browary","Kyevsky",308,65);
            myAddres.AddresOut();
            Console.ReadKey();
        }
    }
}
