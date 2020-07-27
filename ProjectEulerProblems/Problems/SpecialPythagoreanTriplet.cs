using System;

namespace ProjectEulerProblems {
    /// <summary>
    /// Problem #9 
    /// Special Pythagorean Triplet
    /// 
    /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    /// pow(a. 2) + pow(b, 2) = pow(c, 2)
    /// 
    /// For example, pow(3, 2) + pow(4, 2) = 9 + 16 = 25 = pow(5, 2).
    /// 
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>

    public class SpecialPythagoreanTriplet {

        public const int REQUIRED_SUM = 1000;
        
        public static int FindProductOfSpecialPythagoreanTriplet(int[] specialPhythagoreanTriplet) {
            return specialPhythagoreanTriplet[0] * specialPhythagoreanTriplet[1] * specialPhythagoreanTriplet[2];
        }

        public static int[] FindSpecialPythagoreanTriplet() {

            for (int a = 0; a < REQUIRED_SUM; a++) {

                for (int b = 0; b < REQUIRED_SUM; b++) {

                    for (int c = 0; c < REQUIRED_SUM; c++) {

                        if (IsValidNrSequence(a, b, c)) {

                            if (SumEqualsThousend(a, b, c)) {

                                if (ASquarePlusBSquareEqualsCSquare(a, b, c)) {

                                    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
                                    return new int[3] { a, b, c };
                                }
                            }
                        }
                    }
                }
            }
            return new int[0];
        }
        
        private static bool IsValidNrSequence(int a, int b, int c) {
            return a < b && b < c;
        }

        private static bool SumEqualsThousend(int a, int b, int c) {
            return a + b + c == REQUIRED_SUM;
        }
        
        private static bool ASquarePlusBSquareEqualsCSquare(int a, int b, int c) {
            return Square(a) + Square(b) == Square(c);
        }

        public static int Square(int nr) {
            return (int) Math.Pow(nr,  2);
        }
    }
}