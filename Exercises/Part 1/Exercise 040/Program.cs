using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

            int sum = 0;
            int count = 0;

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
                    sum +=num;
                    count += 1;
                }
            }
            Console.WriteLine("Total sum of numbers: " + sum + "\nTotal amount of numbers: " + count );

        }
    }
}
