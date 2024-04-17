using System;

namespace BillSplit
{
    public class PaymentSplitter
    {
        public decimal SplitPayment(decimal amount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
                throw new ArgumentException("Number of people must be greater than zero.");

            return amount / numberOfPeople;
        }
    }
}
