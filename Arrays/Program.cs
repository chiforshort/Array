using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int[] ArrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = new int[] { 1, 3, 5, 7, 9 };
            int[] ArrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            int SumA = ArrayA.Sum();
            int SumB = ArrayB.Sum();
            int SumC = ArrayC.Sum();

            double AverageA = ArrayA.Average();
            double AverageB = ArrayB.Average();
            double AverageC = ArrayC.Average();

            Program.Sum(SumA, SumB, SumC, AverageA, AverageB, AverageC);

            Array.Reverse(ArrayA);
            Array.Reverse(ArrayB);
            Array.Reverse(ArrayC);

            //Part 2: Reversing Arrays
            Console.WriteLine("2. Reversing Arrays \n");
            Console.WriteLine($"Reverse of ArrayA: " + string.Join(",", ArrayA));
            Console.WriteLine($"Reverse of ArrayB: " + string.Join(", ", ArrayB));
            Console.WriteLine($"Reverse of ArrayC: " + string.Join(",", ArrayC));
            Console.ReadLine();
            Console.Clear();

            Array.Reverse(ArrayA);
            Array.Reverse(ArrayB);
            Array.Reverse(ArrayC);

            var RotA = ArrayA[0];
            for (var i = 0; i < ArrayA.Length - 1; i++)
            {
                ArrayA[i] = ArrayA[i + 1];
            }
            ArrayA[ArrayA.Length - 2] = RotA;

            var RotB = ArrayB[0];
            for (var i = 0; i < ArrayB.Length - 3; i++)
            {
                ArrayB[i] = ArrayB[i + 1];
            }
            ArrayA[ArrayA.Length - 2] = RotB;

            var RotC = ArrayC[0];
            for (var i = 0; i < ArrayC.Length - 1; i++)
            {
                ArrayC[i] = ArrayC[i + 1];
            }
            ArrayC[ArrayC.Length - 2] = RotC;
            Console.WriteLine("\nRotated A: [{0}]", string.Join(", ", ArrayA));
            Console.WriteLine("\nRotated B: [{0}]", string.Join(", ", ArrayB));
            Console.WriteLine("\nRotated C: [{0}]", string.Join(", ", ArrayC));



        }
        public static void Sum(int SumA, int SumB, int SumC, double AverageA, double AverageB, double AverageC)
        {
            //Part 1: Finding the sum and average

            Console.WriteLine("1. Counting, Summing, Computing the Mean \n ");
            Console.WriteLine($"The sum of Array A is {SumA}");
            Console.WriteLine($"The sum of Array B is {SumB}");
            Console.WriteLine($"The sum of Array C is {SumC}");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1. Counting, Summing, Computing the Mean \n ");
            Console.WriteLine($"The average of Array A is {AverageA}");
            Console.WriteLine($"The average of Array B is {AverageB}");
            Console.WriteLine($"The average of Array C is {AverageC}");
            Console.ReadLine();
            Console.Clear();
        }




    }
}

