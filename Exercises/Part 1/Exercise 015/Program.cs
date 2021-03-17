using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Give a string:");
            string mssg = Console.ReadLine();

            Console.WriteLine("Give an integer:");
            string numInput = Console.ReadLine();
            int num = Convert.ToInt32(numInput);
            
            Console.WriteLine("Give a double:");
            string doubInput = Console.ReadLine();
            double doubVal = Convert.ToDouble(doubInput);
            
            Console.WriteLine("Give a boolean");
            string boolInput = Console.ReadLine();
            bool boolVal = Convert.ToBoolean(boolInput);
            
            Console.WriteLine("Your string: " + mssg);
            Console.WriteLine("Your integer: " + num);
            Console.WriteLine("Your double: " + doubVal);
            Console.WriteLine("Your boolean: " + boolVal);

        }
  }
}
