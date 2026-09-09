using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    public class Book
    {
        public static int Count = 0;
        public string Title { get; set; }
        public string Author { get; set; }
        private int pageCount { get; set; }
        public int PageCount { get { return pageCount; } set { if (value < 0) { pageCount = 0; } else { pageCount = value; } } }
        public bool isAvailabel { get; set; }

        public Book(string Title, string Author, int pageCount) : this(Title,Author)
        {
            this.Title = Title;
            this.Author = Author;
            this.pageCount = pageCount;
            Count++;
            this.isAvailabel = true;
        }
        public Book(string Title,string Author) 
        {
            this.pageCount=0;
        }
        public void Describe()
        {
            Console.WriteLine($"{Title},{Author},{pageCount}");
        }
        public bool IsLong()
        {
            if (pageCount > 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Borrow()
        {
            if (isAvailabel == true)
            {
                isAvailabel = false;
                Console.WriteLine("kikölcsönözve");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Return()
        {
            if (isAvailabel == false)
            {
                isAvailabel = true;
                Console.WriteLine("kikölcsönözve");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
