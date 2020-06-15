using System;

namespace ProjectEulerProblems {
    /// <summary>
    /// Project Euler Problem #6
    /// 
    /// The sum of the squares of the first ten natural numbers is,
    /// 1(pwr)+2(pwr)+...+10(pwr)=385
    /// 
    /// The square of the sum of the first ten natural numbers is,
    /// (1+2+...+10)(pwr)=55(pwr)=3025
    /// 
    /// Hence the difference between the sum of the squares of the first ten natural 
    /// numbers and the square of the sum is 3025−385=2640.
    /// 
    /// Find the difference between the sum of the squares of the first one hundred 
    /// natural numbers and the square of the sum.
    /// 
    /// </summary>

    public class SumSquareDifference {

        public static int CalculateSumSquareDifference(int MaxNr) {

            return SquareOfSumOfRangeOneThroughMaxNr(MaxNr) - SumOfSquaresOfRangeOneThroughMaxNr(MaxNr);
        }

        public static int SumOfSquaresOfRangeOneThroughMaxNr(int MaxNr) {

            int sumOfSquares = 0;

            for (int i = 1; i <= MaxNr; i++) {
                sumOfSquares += (int)Math.Pow(i, 2);
            }

            return sumOfSquares;
        }

        public static int SquareOfSumOfRangeOneThroughMaxNr(int MaxNr) {

            int sum = 0;

            for (int i = 1; i <= MaxNr; i++) {
                sum += i;
            }

            return (int)Math.Pow(sum, 2);
        }
    }
}