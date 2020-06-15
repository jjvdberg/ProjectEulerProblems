using System;

namespace ProjectEulerProblems {
    class Program {
        static void Main() {
            Console.WriteLine();
        }
    }


    /// <summary>
    /// palindromic number reads the same both ways. 
    /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// 
    /// Find the largest palindrome made from the product of two 3 - digit numbers.
    /// </summary>
    public class LargestPalindronePruduct {

        /// <summary>
        /// This method calculates the biggest product of 2 numbers of N digits that is a palindrone
        /// </summary>
        /// <param name="NrOfDigits"></param>
        /// <returns>int[3], 
        ///          index 0: The largest palindrone product 
        ///          index 1: The first of two numbers (of N digits)
        ///          index 2: The second of two numbers (of N digits) </returns>
        public static int[] CalculateLargestPalindroneProduct(int NrOfDigits) {

            int MaxNr = GetMaxNumber(NrOfDigits);
            int BiggestProductOfJAndI = 0;
            int BiggestI = 0;
            int BiggestJ = 0;

            for (int i = MaxNr; i > 0; i--) {
                for (int j = MaxNr; j > 0; j--) {
                    
                    int ProductOfJAndI = j * i;
                    if (IsPalindromicNumber(ProductOfJAndI)) {

                        if (ProductOfJAndI > BiggestProductOfJAndI) {
                            BiggestProductOfJAndI = ProductOfJAndI;
                            BiggestI = i;
                            BiggestJ = j;
                        }
                    }
                }
            }

            return new int[3] { BiggestProductOfJAndI, BiggestI, BiggestJ };
        }

        public static int GetMaxNumber(int NrOfDigits) {
            string nine = "9";
            string MaxNumberStr = "";
            for (int i = 0; i < NrOfDigits; i++) {
                MaxNumberStr += nine;
            }
            return Int32.Parse(MaxNumberStr);
        }

        public static bool IsPalindromicNumber(int nr) {

            var nrToString = nr.ToString();
            return IsPalindrome(nrToString);
        }

        public static bool IsPalindrome(string str) {

            int len = str.Length;

            if (len == 1) {
                return true;
            }

            for (int i = 0; i < len / 2; i++) {
                if (!(str[i] == str[len - i - 1])) {
                    return false;
                }
            }

            return true;
        }
    }
}