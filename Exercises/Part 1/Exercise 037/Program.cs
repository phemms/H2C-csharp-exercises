using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
            while (true)
            {
                Console.WriteLine("Give a number:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
                else
                {
                    sum = sum + 1;
                }
            }
            Console.WriteLine("Total amount of numbers: " + sum);

        }
  }
}
