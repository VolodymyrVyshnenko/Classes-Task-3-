using System;

namespace _3
{
    public class Content
    {
        public string BookContent { get; set; }
        public void Show()
        {
            Console.WriteLine("Содержание книги: " + BookContent);
        }
    }
}