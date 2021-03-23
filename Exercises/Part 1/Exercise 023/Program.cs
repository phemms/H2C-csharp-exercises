using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give the first number!"); // request numbers
            string num = Console.ReadLine();
            int firstNum = Convert.ToInt32(num);
            Console.WriteLine("Give the second number!");
            num = Console.ReadLine();
            int secondNum = Convert.ToInt32(num);
            Console.WriteLine(firstNum + " + " + secondNum + " = " + (firstNum+secondNum));
            Console.WriteLine(firstNum + " - " + secondNum + " = " + (firstNum-secondNum));
            Console.WriteLine(firstNum + " * " + secondNum + " = " + firstNum * secondNum);
            Console.WriteLine(firstNum + " / " + secondNum + " = " + (double)firstNum / secondNum);

        }
  }
}
