using System;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Назва книги: ");
            Titles title = new Titles();
            title.Content = Console.ReadLine();
            Console.WriteLine("Автор книги: ");
            Authors author = new Authors();
            author.Content =  Console.ReadLine();
            Console.WriteLine("Зміст книги: ");
            Contents content = new Contents();
            content.Content =  Console.ReadLine();
            Book book = new Book(title,author,content);
            book.Show();
            Console.ReadKey();

        }
    }
}
