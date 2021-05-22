using System;

namespace democonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "J.R.R Tolkein", 700);

            Console.WriteLine(book1.pages);
            Console.ReadLine();
        }
    }
}
