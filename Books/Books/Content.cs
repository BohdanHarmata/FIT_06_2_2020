using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    class Contents
    {
        string _content;
        public string Content
        {
            get
            {
                if (_content != null)
                    return _content;
                else
                    return ("Автора нема");
            }
            set
            {
                _content = value;
            }
        }

        public void Show()
        {
            Console.WriteLine(_content);
        }
    }
}
