using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProjectEulerProblems.Tests.Tests {
    public class SmallestMultipleTests {

        [Theory]
        [ClassData(typeof(SmallestMultipleTestData))]
        public static void DeviderAlgorithm_FindSmallestMultiple_ShouldWork(int[] deviders, int expected) {

            int actual = SmallestMultiple.DeviderAlgorithm(deviders);

            Assert.Equal(expected, actual);
        }
    }

    public class SmallestMultipleTestData : IEnumerable<object[]> {
        public IEnumerator<object[]> GetEnumerator() {
            yield return new object[] { SmallestMultiple.devidersOneThroughTen, 2520 };
            yield return new object[] { SmallestMultiple.devidersOneThroughTwenty, 232792560 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
