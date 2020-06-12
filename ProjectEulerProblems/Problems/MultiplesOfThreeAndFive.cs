using System;

public class MultiplesOfThreeAndFive {

    public static bool IsMultipleOfThree(int nr) {
        return (nr % 3 == 0);
    }

    public static bool IsMultipleOfFive(int nr) {
        return (nr % 5 == 0);
    }

    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, 
    /// we get 3, 5, 6 and 9.The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    /// <param name="total"></param>
    /// <returns>int sum: The total sum of all multiples of 3 and 5</returns>
    public static int SumOfAllMultiplesOfThreeOrFive(int total) {

        int sum = 0;

        for (int i = 0; i <= total; i++) {
            if (IsMultipleOfThree(i) || IsMultipleOfFive(i)) {
                sum += i;
            }
        }

        return sum;
    }
}