using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0) num *= -1;
            Console.WriteLine(num);
      
    }
  }
}
