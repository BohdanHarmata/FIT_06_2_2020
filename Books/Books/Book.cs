using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    class Book
    {

        Titles title;
        Authors author;
        Contents contents;
        public Book(string title,string author, string contents)
        {
            this.title.Content = title;
            this.author.Content = author;
            this.contents.Content = contents;


        }

        public Book(Titles title, Authors author, Contents content)
        {
            this.title = title;
            this.author = author;
            this.contents = content;
        }

        public void Show()
        {
            title.Show();
            author.Show();
            contents.Show();
        }

    }
}
