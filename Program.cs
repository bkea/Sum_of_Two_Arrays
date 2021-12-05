using System;

namespace TwoArrysSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5] { 99, 98, 92, 97, 95 };
            int[] B = new int[5] { 99, 98, 92, 97, 95 };
            int K = solution(A, B);
            if (K == 0)
            {
                Console.WriteLine(" K is fair");
            }
            else
            {
                Console.WriteLine(" K is not fair");
            }
        }
        public static int solution(int[] A, int[] B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int sumA = 0;
            int sumB = 0;

            for (int K = 0; K < A.Length - 1; ++K)
            {
                sumA += A[K];

            }

            for (int K = 0; K < B.Length - 1; ++K)
            {
                sumB += B[K];
            }

            if (sumA > sumB)
            {
                return sumA - sumB;
            }
            else if (sumB > sumA)
            {
                return sumB - sumA;
            }
            else
            {
                return 0;
            }
        }
    }
}
