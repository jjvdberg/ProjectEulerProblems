using System;

namespace ProjectEulerProblems {
    public class Program {
        static void Main() {
            int answer = TenThousendAndFirstPrimeNumber.GetNthPrimeNumber(10001);
            Console.WriteLine($"Answer = {answer}");
        }
    }
}