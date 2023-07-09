using Lab08Program.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Program.Classes
{
    public class Library : ILibrary
    {
        private Dictionary<string, Book> libraryBooks;

        public Library()
        {
            libraryBooks = new Dictionary<string, Book>();
        }
        public int Count => libraryBooks.Count;

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
           string author = $"{firstName} {lastName}";
           Book book = new Book(title,author, numberOfPages);
           libraryBooks[title] = book;
        }

        public Book Borrow(string title)
        {
            if(libraryBooks.ContainsKey(title))
            {
                Book book = libraryBooks[title];
                libraryBooks.Remove(title);
                return book;
            }
            return null;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return libraryBooks.Values.GetEnumerator();
        }

        public void Return(Book book)
        {
            libraryBooks[book.Title] = book;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
