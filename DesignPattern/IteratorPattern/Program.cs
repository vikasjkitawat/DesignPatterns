using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BookContainer books = new BookContainer();
            books.Add("1");
            books.Add("2");
            books.Add("3");
            books.Remove();

            while (books.MoveNext())
            {
                Console.WriteLine(books.Current);
            }

            books.Reset();

            while (books.MoveNext())
            {
                Console.WriteLine(books.Current);
            }
            Console.ReadKey();
        }
    }
}
