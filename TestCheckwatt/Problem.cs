using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCheckwatt
{
    public class Problem
    {
        public static int Multiples(int a, int b)
        {
            int result = 0;
            Console.WriteLine("All multiples:");
            for (int i = 1; i < 1000; i++)
            {
                if (i % a == 0 || i % b == 0)
                {
                    Console.Write($"{i} ");
                    result += i;
                }
            }
            return result;
        }

        public static long PrimeFactor(long number)
        {
            Console.WriteLine("Other factors:");
            for (long i = 2; i <= Math.Sqrt(number); i++)   
            {
                while (i <= Math.Sqrt(number) && number % i == 0)
                {
                    Console.Write($"{i} ");
                    number /= i;
                }
            }
            return number;
        }  
        public static void CollatzSequence(int range)
        {
            int number = 0;
            int maxCount = 0;
            Dictionary<long, int> index = []; // >>>>>>>>>>>>>>>  To minimize the amount of divisions and multiplications needed to arrive at 1.
            for (int i = 2; i < range; i++)                     //Once the program finds a number that it's already counted, it will just add
            {                                                   //the current number of counts to the previously stored.
                int count = CollatzIteration(i, index);
                if (count > maxCount)
                {
                    maxCount = count;
                    number = i;
                    Console.Write($"[{number}, {maxCount}]");
                }
            }
            Console.WriteLine($"\n\nUnder {range}, {number} will produce the longest Collatz sequence: {maxCount} terms.");
        }

        static int CollatzIteration(long n, Dictionary<long, int> index)
        {
            int count = 0;
            long indexKey = n;

            while (n != 1)
            {
                if (index.ContainsKey(n))
                {
                    index.TryGetValue(n, out int storedCount);
                    count += storedCount;
                    break;
                }
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }

                count++;
            }

            index.Add(indexKey, count);
            return count;
        }
    }
}
