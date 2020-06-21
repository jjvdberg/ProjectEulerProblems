using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests {
    public class LargestProductInASeriesTests {

        [Theory]
        [InlineData(4, 5832)]
        [InlineData(13, 23514624000)]
        public void LargestProductInASeries_ShouldWork(int N, long expected) {

            long actual = LargestProductInASeries.ProductOfNAdjacentDigits(N);

            Assert.Equal(expected, actual);
        }
    }
}
