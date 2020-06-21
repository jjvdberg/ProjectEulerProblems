using System;

namespace ProjectEulerProblems {
    public class Program {
        static void Main() {
            long answer = LargestProductInASeries.ProductOfNAdjacentDigits(13);
            Console.WriteLine($"Answer = {answer}");
        }
    }
}