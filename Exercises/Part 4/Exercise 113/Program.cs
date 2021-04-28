using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
            // IMPLEMENT YOUR CODE IN HERE!
            // Remember also to create the file Book.cs and class in it!
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                if(name == "")
                {
                    break;
                }
                Console.WriteLine("Pages: ");
                int page = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Publication year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                books.Add(new Book(name, page, year));
            }
            Console.WriteLine();
            Console.WriteLine("What information will be printed? ");
            string s = Console.ReadLine();
            foreach(Book b in books)
            {
                if (s == "everything")
                    Console.WriteLine(b);
                else if (s == "Title")
                    Console.WriteLine(b.name);
                else
                    break;
            }

        }
  }
}




