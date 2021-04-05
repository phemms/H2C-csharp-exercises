using System;

namespace exercise_49
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("How many times?");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < num)
            {
                PrintPhrase();
                i++;
            }
            
 
    }

    
    public static void PrintPhrase() {
            Console.WriteLine("In a hole in the ground there lived a method");

    }
  }
}
