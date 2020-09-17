using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee
    {
        private string _firstname;
        private string _lastname;
        public int days = 20;
        public int workdays = 18;
        public Employee(string firstname,string lastname)
        {
            this._firstname = firstname;
            this._lastname = lastname;
        }
        public double Oklad(int days, int workdays)
        {
            int oklad = 25000 / days * workdays;
            return oklad;
        }
        public void Show()
        {
            Console.WriteLine($"Ім'я {_firstname}");
            Console.WriteLine($"Призвіще {_lastname}");
            Console.WriteLine($"Оклад {Oklad(days,workdays)}");
        }

    }
}
