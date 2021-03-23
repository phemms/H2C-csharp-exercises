using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give the first number!");
            string num = Console.ReadLine();
            int firstNum = Convert.ToInt32(num);
            Console.WriteLine("Give the second number!");
            num = Console.ReadLine();
            int secondNum = Convert.ToInt32(num);
            Console.WriteLine("Give the third number!");
            num = Console.ReadLine();
            int thirdNum = Convert.ToInt32(num);
            double avg = (firstNum + secondNum + thirdNum)/3.0;
            Console.WriteLine("The average is " + avg);

        }
  }
}
