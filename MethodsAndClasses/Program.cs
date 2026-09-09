namespace MethodsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Micimackó", "egy angol író",300);
            Book book2 = new Book("Kockás fülű nyúl", "egy magyar író", -100);
            Console.WriteLine(book1.Title,book2.Title);

            book1.Describe();
            book2.Describe();
            book1.IsLong();
            book2.IsLong();

            Book book3 = new Book("kis vakond", "valami európai");
            book2.Borrow();
            Book book4 = new Book("kis herceg", "egy európai író", 500);
            Book book5 = new Book("minecraft", "egy német író", 200);

            Library Library = new Library("könyvtár");
                        Library.AddBook(book1);
                        Library.AddBook(book2);
                        Library.AddBook(book3);
                        Library.AddBook(book4);
                        Library.AddBook(book5);
            Library.PrintAll();
            Library.AvailableBooks();
        }
    }
}
