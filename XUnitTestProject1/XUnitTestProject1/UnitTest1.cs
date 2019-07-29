using System;
using System.Linq;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        public void ReturnFalseGivenValueLessThan2(int value)
        {
            // Arrange - values set in theory
            // new up service to act on
            PrimeService primeService = new PrimeService();

            // Act 
            var actual = primeService.isPrime(value);
            
            // Assert
            Assert.False(actual);
        }


        
    }

    public class PrimeService
    {
        public bool isPrime(int x)
        {
            if (x < 2)
            {
                return false;
            }
            for (var divisor = 2; divisor <= Math.Sqrt(x); divisor++)
            {
                if (x % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
