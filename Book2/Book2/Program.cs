using System;

namespace Book2
{

    class Book
    {
        private int year;
        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                if (value > 2020)
                    year = 2020;
                else if (value < 1940)
                    year = 1940;
                else year = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Year = 2045;
            Console.WriteLine(book.Year + " (В коде указан год >2020)");
            book.Year = 1945;
            Console.WriteLine(book.Year);
            Console.ReadLine();
         }
    }
}
