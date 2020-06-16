using System;

namespace ProjectEulerProblems {
    /// <summary>
    /// Problem #7: 10001st prime
    /// 
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
    /// we can see that the 6th prime is 13.
    /// 
    /// What is the 10 001st prime number?
    /// </summary>
    public class TenThousendAndFirstPrimeNumber {

        /// <summary>
        /// Given N, returns the Nth Prime number. 
        /// For example: 
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
        /// we can see that the 6th prime is 13.
        /// Here N would be 6 and the return value would be 13.
        /// </summary>
        /// <param name="N">A positive integer representing what prime number sequence you want to see</param>
        /// <returns>The Nth prime number</returns>
        public static int GetNthPrimeNumber(int N) {

            if (N <= 0) {
                throw new ArgumentOutOfRangeException("Please provide a positive integer for N");
            }

            int count = 0;
            int i = 0;

            do {
                i++;
                if (IsPrime(i)) {
                    count++;
                }
            } while (count < N);

            return i;
        }

        public static bool IsPrime(int number) {

            if (number < 2) {
                return false;
            }

            for (int i = 2; i * i <= number; i++) {
                if (number % i == 0) {
                    return false;
                }
            }

            return true;
            
        }
    }
}