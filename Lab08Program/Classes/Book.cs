using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Program.Classes
{
    public class Book 
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public int numberOfPages { get; set; }
        public Book(string Title,string Author,int numberOfPages)
        {
            this.Title = Title;
            this.Author = Author;
            this.numberOfPages = numberOfPages;

        }
    }
}
