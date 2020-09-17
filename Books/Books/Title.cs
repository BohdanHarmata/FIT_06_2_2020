using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    class Titles
    {

          string _title;
          public string Content
        {
            get
            {
                if (_title != null)
                    return _title;
                else
                    return ("Автора нема");
            }
            set
            {
                _title = value;
            }
        }


        public void Show()
        {
            Console.WriteLine(_title);
        }
    }
}
