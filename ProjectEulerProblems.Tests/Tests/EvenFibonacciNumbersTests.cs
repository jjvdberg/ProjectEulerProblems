using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests {
    public class EvenFibonacciNumbersTests {

        [Fact]
        public void FindSumOfAllEvenFibonacciSequencesBelowMax_ShouldWork() {

            int expected = 4613732;

            int actual = EvenFibonacciNumbers.SumOfAllFibonacciEvenNumbers(4000000);

            Assert.Equal(expected, actual);
        }
    }
}
