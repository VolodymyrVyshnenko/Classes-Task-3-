using System;

namespace _3
{
    public class Title
    {
        public string BookName { get; set; }
        public void Show()
        {
            Console.WriteLine("Название книги: " + BookName);
        }
    }
}