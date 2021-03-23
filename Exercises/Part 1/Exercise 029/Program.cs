using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give the first number!");
            string userInput = Console.ReadLine();
            int firstNum = Convert.ToInt32(userInput);
            Console.WriteLine("Give the second number");
            userInput = Console.ReadLine();
            int secondNum = Convert.ToInt32(userInput);
            if (firstNum > secondNum)
            {
                Console.WriteLine("It larger number is " + firstNum);
            }

            else if(firstNum < secondNum)
            {
                Console.WriteLine("The larger number is " + secondNum);
            }
            else if (firstNum == secondNum)
            {
                Console.WriteLine("They are eqaul!");
            }

        }
  }
}
