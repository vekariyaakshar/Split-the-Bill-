using Xunit;
using BillSplit;

namespace BillMethod
{
    public class BillMethod
    {
        [Fact]
        public void SplitPayment_EvenSplit_ReturnsCorrectAmount()
        {
        
            var splitter = new PaymentSplitter();
            decimal amount = 100m;
            int numberOfPeople = 4;

            
            var result = splitter.SplitPayment(amount, numberOfPeople);

            
            Assert.Equal(25m, result);
        }

        [Fact]
        public void SplitPayment_UnevenSplit_ReturnsCorrectAmount()
        {
            
            var splitter = new PaymentSplitter();
            decimal amount = 100m;
            int numberOfPeople = 3;

            
            var result = splitter.SplitPayment(amount, numberOfPeople);

           
            Assert.Equal(33.33m, Math.Round(result, 2));
        }

        [Fact]
        public void SplitPayment_ZeroPeople_ThrowsArgumentException()
        {
           
            var splitter = new PaymentSplitter();

            
            Assert.Throws<ArgumentException>(() => splitter.SplitPayment(100m, 0));
        }
    }
}
