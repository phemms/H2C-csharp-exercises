using System;
namespace exercise_109
{
    public class PaymentCard
    {
        public double balance { get; set; }
        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
        }
        public void EatLunch()
        {
            if (this.balance < 10.6) this.balance -= 0;
            else
                this.balance -= 10.60;
        }
        public void DrinkCoffee()
        {
            if (this.balance < 2) this.balance -= 0;
            else
                this.balance -= 2.0;
        }
        public void AddMoney(double amount)
        {
            if (amount < 0) amount = 0;
            this.balance += amount;
            if (this.balance > 150) this.balance = 150;
        }
        public override string ToString()
        {
            return "This card has a balance of " + this.balance + " euros.";
        }
    }
}

