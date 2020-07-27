using System;

namespace ProjectEulerProblems {
    public class Program {
        static void Main() {
            var triplet = SpecialPythagoreanTriplet.FindSpecialPythagoreanTriplet();
            if (triplet.Length == 3) {
                var answer = SpecialPythagoreanTriplet.FindProductOfSpecialPythagoreanTriplet(triplet);
                Console.WriteLine($"Answer = {answer}");
            }
        }
    }
}