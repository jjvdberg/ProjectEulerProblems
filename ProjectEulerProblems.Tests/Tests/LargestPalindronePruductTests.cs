using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests {
    public class LargestPalindronePruductTests {

        [Theory]
        [InlineData(2, 9009)]
        [InlineData(3, 906609)]
        public void FindLargestPalindronePruduct_ShouldWork(int NrOfDigits, int expected) {

            int actual = LargestPalindronePruduct.CalculateLargestPalindroneProduct(NrOfDigits)[0];

            Assert.Equal(expected, actual);
        }
    }
}
