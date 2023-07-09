using Lab08Program.Classes;

namespace Lab08Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Add("Book 1", "John", "Doe", 200);
            library.Add("Book 2", "Jane", "Smith", 150);


            Book borrowedBook = library.Borrow("Book 1");

            Backpack<Book> backpack = new Backpack<Book>();
            backpack.Pack(borrowedBook);

            Book unpackedBook = backpack.Unpack(0);
            library.Return(unpackedBook);

            Console.ReadKey();
        }
    }
}