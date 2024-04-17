using System;
using System.Collections.Generic;

namespace BillSplit
{
    public class Payment
    {
        public Dictionary<string, decimal> CalculateTips(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            if (mealCosts == null)
                throw new ArgumentNullException(nameof(mealCosts));

            if (tipPercentage < 0)
                throw new ArgumentException("Tip percentage must be non-negative.", nameof(tipPercentage));

            var tips = new Dictionary<string, decimal>();

            foreach (var entry in mealCosts)
            {
                decimal tipAmount = entry.Value * ((decimal)tipPercentage / 100);
                tips[entry.Key] = Math.Round(tipAmount, 2); // Rounding to two decimal places for currency representation
            }

            return tips;
        }
    }
}
