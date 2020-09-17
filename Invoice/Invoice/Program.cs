using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice myInvoice = new Invoice(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
            myInvoice.Show();
            Console.ReadKey();
        }
    }
}
