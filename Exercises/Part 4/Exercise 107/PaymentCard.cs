using System;
namespace exercise_107
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
            this.balance -= 10.60;
        }
        public void DrinkCoffee()
        {
            this.balance -= 2.0;
        }
        public override string ToString()
        {
            return "This card has a balance of " + this.balance + " euros.";
        }
    }
}