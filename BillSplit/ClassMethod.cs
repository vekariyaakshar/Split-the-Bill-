using System;

namespace BillSplit
{
    public class classMethod
    {
        public decimal CalculateTipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
        {
            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero.", nameof(price));

            if (numberOfPatrons <= 0)
                throw new ArgumentException("Number of patrons must be greater than zero.", nameof(numberOfPatrons));

            if (tipPercentage < 0)
                throw new ArgumentException("Tip percentage must be non-negative.", nameof(tipPercentage));

            decimal totalTipAmount = price * ((decimal)tipPercentage / 100);
            decimal tipPerPerson = totalTipAmount / numberOfPatrons;

            return tipPerPerson;
        }
    }
}
