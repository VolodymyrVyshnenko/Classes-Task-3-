using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book;
            Console.WriteLine("Введите название книги и её автора через знак доллара:");
            string[] input = Console.ReadLine().Split('$');
            Console.WriteLine("Введите содержание книги: ");
            string content = Console.ReadLine();
            book = new Book(input[1], input[0], content);
            book.Show();

            
            Console.ReadKey();
        }
    }
}
