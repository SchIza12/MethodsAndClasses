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


        }
    }
}
