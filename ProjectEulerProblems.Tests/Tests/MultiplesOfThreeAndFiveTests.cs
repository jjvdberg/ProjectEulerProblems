using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests {
    public class MultiplesOfThreeAndFiveTests {

        [Theory]
        [InlineData(23, 9)]
        [InlineData(233168, 999)]
        public void FindSumOfAllMultiplesOfThreeOrFive_ShouldWork(int expected, int total) {

            int actual = MultiplesOfThreeAndFive.SumOfAllMultiplesOfThreeOrFive(total);

            Assert.Equal<int>(expected, actual);
        }
    }
}
