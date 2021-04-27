using System;
namespace exercise_106
{
    public class PaymentCard
    {
        public double balance { get; set; }
        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
        }
        public override string ToString()
        {
            return "This card has a balance of " + this.balance + " euros.";
        }
    }
}
