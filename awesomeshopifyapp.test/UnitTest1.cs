using System;
using Xunit;

namespace awesomeshopifyapp.test
{
    public class UnitTest1
    {
        // fib: 1 1 2 3 5 8 13 ...

        [Fact]
        public void Fib_ShouldReturnValidResult_WhenNumberIsGreaterThanZero()
        {
            Assert.Equal(13, fib(7));
        }

        [Fact]
        public void Fib_ShouldReturnValidResult_WhenNumberIsZero()
        {
            Assert.Equal(0, fib(0));
        }

        [Fact]
        public void Fib_ShouldReturnValidResult_WhenNumberIsSmallerThanZero()
        {
            Assert.Throws<Exception>(() => fib(-5));
        }

        private int fib(int n)
        {
            if (n < 0)
            {
                throw new Exception("Value must be greater or equan than 0");
            }

            if (n == 0)
            {
                return 0;
            }

            if (n <= 2)
            {
                return 1;
            }

            return fib(n - 2) + fib(n - 1);
        }
    }
}
