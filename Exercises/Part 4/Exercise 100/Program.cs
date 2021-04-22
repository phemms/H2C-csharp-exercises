using System;

namespace exercise_100
{
    class Program
    {
        public static void Main(string[] args)
        {
            Debt mortgage = new Debt(120000.0, 1.01);
            mortgage.PrintBalance();

            mortgage.WaitOneYear();
            mortgage.PrintBalance();

            // Wait 20 years
            int years = 0;
            while (years < 20)
            {
                mortgage.WaitOneYear();
                years = years + 1;
            }

            mortgage.PrintBalance();
        }
        public class Debt
            {
                private double balance;
                private double interestRate;
                public Debt(double initialBalance, double initialInterestRate)
            {
                this.balance = initialBalance;
                this.interestRate = initialInterestRate;
            }
            public void PrintBalance()
            {
                Console.WriteLine(this.balance);
            }
            public void WaitOneYear()
            {
                this.balance = this.balance * this.interestRate;
            }
            }

  }
}



