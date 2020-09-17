using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    class Authors
    {
        string _author;

            
        public string Content
        {
            private get
            {
                if (_author != null)
                    return _author;
                else
                    return ("Автора нема");
            }
            set
            {
                _author = value;
            }
        }


        public void Show()
        {
            Console.WriteLine(_author);
        }
    }
}
