using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests {
    public class SumSquareDifferenceTests {

        [Fact]
        public void SumOfSquaresOfRangeOneThroughMaxNr_ShouldWork() {

            int expected = 385;

            int actual = SumSquareDifference.SumOfSquaresOfRangeOneThroughMaxNr(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SquareOfSumOfRangeOneThroughMaxNr_ShouldWork() {

            int expected = 3025;

            int actual = SumSquareDifference.SquareOfSumOfRangeOneThroughMaxNr(10);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(10, 2640)]
        [InlineData(100, 25164150)]
        public void CalculateSumSquareDifference_ShouldWork(int MaxNr, int expected) {

            int actual = SumSquareDifference.CalculateSumSquareDifference(MaxNr);

            Assert.Equal(expected, actual);
        }
    }
}
