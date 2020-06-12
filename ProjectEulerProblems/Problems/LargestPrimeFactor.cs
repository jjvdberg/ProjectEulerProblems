public class LargestPrimeFactor {

    public static bool IsPrime(long number) {

        if (number < 2) {
            return false;
        }

        for (long i = 2; i * i <= number; i++) {
            if (number % i == 0) {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    /// <param name="number"></param>
    /// <returns>The largest prime factor</returns>
    public static long BiggestPrimeFactor(long number) {

        for (long i = 2; i < number / 2; i++) {
            var factor = number / i;
            if (IsPrime(factor)) {
                if (number % factor == 0) {
                    return factor;
                }
            }
        }

        return -1;
    }
}