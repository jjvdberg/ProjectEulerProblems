using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests {
    public class LargestPrimeFactorTests {

        [Theory]
        [InlineData(29, 13195)]
        [InlineData(6857, 600851475143)]
        public void FindLargestPrimeFactor_ShouldWork(long expected, long number) {

            long actual = LargestPrimeFactor.BiggestPrimeFactor(number);

            Assert.Equal(expected, actual);
        }
    }
}
