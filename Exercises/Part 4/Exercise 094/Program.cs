using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
            // DO NOT TOUCH THE OTHER FILE!
            // Do your code here!
            Account account = new Account("Heikki's account", 1000);
            Account account1 = new Account("Personal account", 0);
            account.Withdrawal(100.0);
            account1.Deposit(100.0);
            Console.WriteLine(account);
            Console.WriteLine(account1);

    }
  }
}



