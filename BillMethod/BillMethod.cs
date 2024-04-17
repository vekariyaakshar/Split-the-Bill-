using Xunit;
using BillSplit;

namespace YourTestProjectName
{
    public class PaymentSplitterTests
    {
        [Fact]
        public void SplitPayment_EvenSplit_ReturnsCorrectAmount()
        {
            // Arrange
            var splitter = new PaymentSplitter();
            decimal amount = 100m;
            int numberOfPeople = 4;

            // Act
            var result = splitter.SplitPayment(amount, numberOfPeople);

            // Assert
            Assert.Equal(25m, result);
        }

        [Fact]
        public void SplitPayment_UnevenSplit_ReturnsCorrectAmount()
        {
            // Arrange
            var splitter = new PaymentSplitter();
            decimal amount = 100m;
            int numberOfPeople = 3;

            // Act
            var result = splitter.SplitPayment(amount, numberOfPeople);

            // Assert
            Assert.Equal(33.33m, Math.Round(result, 2));
        }

        [Fact]
        public void SplitPayment_ZeroPeople_ThrowsArgumentException()
        {
            // Arrange
            var splitter = new PaymentSplitter();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => splitter.SplitPayment(100m, 0));
        }
    }
}
