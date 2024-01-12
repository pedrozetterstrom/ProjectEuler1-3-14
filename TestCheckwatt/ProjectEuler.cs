using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TestCheckwatt;

namespace ProjectEuler
{
    public class ProjectEuler
    {
        public static void Menu()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Data data = new();
                Console.WriteLine($" 1. Multiples of {data.problem1[0]} and {data.problem1[1]}\n 2. Largest prime factor of {data.problem3}\n 3. Longest Collatz sequence under {data.problem14}\n 0. End");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine($"\nSum of all multiples: {Problem.Multiples(data.problem1[0], data.problem1[1])}");
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine($"\nLargest factor: {Problem.PrimeFactor(data.problem3)}");
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Clear();
                        Problem.CollatzSequence(data.problem14);
                        Console.ReadKey();
                        break;
                    case '0':
                        Console.Clear();
                        running = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}