using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
            string userName1 = "alex";
            string password1 = "sunshine";
            string userName2 = "emma";
            string password2 = "haskell";
            Console.WriteLine("Enter username:");
            string um = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string pw = Console.ReadLine();
            if (um == userName1 && pw == password1)
               Console.WriteLine("You have successfully logged in");
            else if (um == userName2 && pw == password2)
               Console.WriteLine("You have successfully logged in!");
            else Console.WriteLine("Incorrect username or password!");





    }
  }
}

