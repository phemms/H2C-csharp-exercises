using System;

namespace exercise_17
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
            int sum = firstNum + secondNum;
            Console.WriteLine("The sum is " + sum);
      

    }
  }
}
