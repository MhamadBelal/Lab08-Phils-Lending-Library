using Lab08Program.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Program.Classes
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> items;

        public Backpack()
        {
            items = new List<T>();
        }
        public int Count => items.Count;
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public void Pack(T item)
        {
            if(item!=null)
            {
                items.Add(item);
            }   
        }

        public T Unpack(int index)
        {
            if(index>=0 && index<items.Count)
            {
                T removedBook = items[index];
                items.Remove(removedBook);
                return removedBook;
            }
            throw new IndexOutOfRangeException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
