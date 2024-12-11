using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstEF.Models;

namespace CodeFirstEF
{
    class Program
    {
        static BooksContext db = new BooksContext();

        public static void ShowAllBooks()
        {
            var bk = from b in db.book
                     select b;

            foreach(var item in bk)
            {
                Console.WriteLine($"Book Id : {item.BookId}, Book Name : {item.BookName}, Price :{item.Price}, and Year Published : {item.YearPublished}");
            }
        }

        public static void AddBooks()
        {
            Books b = new Books();
            Console.WriteLine("Enter Bookid, Name, Price, Year :");
            b.BookId = int.Parse(Console.ReadLine());
            b.BookName = Console.ReadLine();
            b.Price = Convert.ToDouble(Console.ReadLine());
            b.YearPublished = Convert.ToDateTime(Console.ReadLine());
            db.book.Add(b);
            db.SaveChanges();
        }

        static void Main(string[] args)
        {
            AddBooks();
            ShowAllBooks();
            Console.Read();
        }
    }
}
