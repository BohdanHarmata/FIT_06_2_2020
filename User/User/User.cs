using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    class User
    {
        private string _login { get; set; }
        private string _firstname { get; set; }
        private string _lastname { get; set; }
        private string _age { get; set; }
        readonly string _dataofanket;
        public User(string login, string firstname, string lastname, string age, string dataofanket) 
        {
            this._login = login;
            this._firstname = firstname;
            this._lastname = lastname;
            this._age = age;
            this._dataofanket = dataofanket;
        }
        public void Show()
        {
            Console.WriteLine($"Логін: {_login}");
            Console.WriteLine($"Ім'я: {_firstname}");
            Console.WriteLine($"Призвіще: {_lastname}");
            Console.WriteLine($"Вік: {_age}");
            Console.WriteLine($"Дата заповнення анкети: {_dataofanket}");
        }
    }
}
