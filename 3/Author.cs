using System;

namespace _3
{
    public class Author
    {
        public string AutName { get; set; }
        public void Show()
        {
            Console.WriteLine("Автор книги: " + AutName);
        }
    }
}