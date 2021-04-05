using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Where to?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where from?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = num1; i <= num; i++)
            {
                Console.WriteLine(i);
            }

        }
  }
}
