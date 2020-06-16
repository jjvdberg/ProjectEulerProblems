using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests {
    public class TenThousendAndFirstPrimeNumberTests {

        [Theory]
        [InlineData(6, 13)]
        [InlineData(10001, 104743)]
        public void GetNthPrimeNumber_ShouldWork(int N, int expected) {

            int actual = TenThousendAndFirstPrimeNumber.GetNthPrimeNumber(N);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetNthPrimeNumber_zero_ShouldThrowException() {

            try {
                var foo = TenThousendAndFirstPrimeNumber.GetNthPrimeNumber(0);
            } catch (Exception actual) {
                Assert.IsType<ArgumentOutOfRangeException>(actual);
            }
        }
    }
}
