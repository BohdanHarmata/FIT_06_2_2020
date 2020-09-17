using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice
{
    class Invoice
    {
        readonly int _account;
        readonly string _customer;
        readonly string _provider;
        private string _article;
        public int quality = 2500;
        public Invoice(int account, string customer, string provider,string article)
        {
            this._account = account;
            this._customer = customer;
            this._provider = provider;
            this._article = article;
        }
        public double NDS(int quality)
        {
            double price = quality - 500;
            return price;
        }
        public void Show()
        {
            Console.WriteLine($"Ціна з НДС {NDS(quality)}");
            Console.WriteLine($"Ціна без НДС {quality}");
        }
    }
}
