using System;

namespace exercise_20
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
            int mult = firstNum * secondNum;
            Console.WriteLine(firstNum + " * " + secondNum + " = " + mult);

        }
  }
}
