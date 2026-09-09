using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    public class Library
    {
        public string Name { get; set; }
        private List<Book>Books { get; set; }
        public int BookCount { get { return Books.Count; } }
        public Library(string Name) 
        {
            Name = Name;
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void PrintAll()
        {
            foreach (Book book in Books)
            {
                book.Describe();
            }
        }
        public Book FindByTitle(string Title)
        {
            foreach (Book book in Books)
            {
                if (book.Title == Title) 
                {
                    return book;
                }
            }
            return null;
        }
        public List<Book> FindByAuthor (string Author)
        {
            List<Book> booksbyauthor = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Author == Author)
                {
                    booksbyauthor.Add(book);
                }
            }
            return booksbyauthor;
        }
        public int TotalPages()
        {
            int total = 0;
            foreach (Book book in Books) 
            {
                total += book.PageCount;
            }
            return total;
        }
        public double AveragePages()
        {
            if(Books.Count == 0)
            {
                return 0;
            }
            return (double)TotalPages()/Books.Count;
        }
        new List<Book> availableBooks = new List<Book>();
        public void AvailableBooks()
        {
            foreach (Book book in Books)
            {
                if (book.isAvailabel)
                {
                    availableBooks.Add(book);
                }
            }
        }
     }
}
