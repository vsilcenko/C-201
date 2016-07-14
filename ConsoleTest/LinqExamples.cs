using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTest
{
    public class LinqExamples
    {
        public static void Run()
        {
            var list = new List<int>
            {
                6, 4, 98, 63, 99, 33, 67, 47, 50, 28, 20, 70, 5, 7, 6
            };

            var smallNumbers = list.Where(x => x < 10);
            foreach (var smallNumber in smallNumbers)
            {
                Console.WriteLine(smallNumber);
            }
            Console.Write("There is at least one number divisible by 13: ");
            Console.WriteLine(list.Any(x => x % 13 == 0));
            Console.Write("All numbers are less than 100: ");
            Console.WriteLine(list.All(x => x < 100));

            var sortedByLastDigit = list.OrderBy(x => x % 10);
            foreach (var i in sortedByLastDigit)
            {
                Console.WriteLine(i);
            }
            var sortedAlphabetically = list.OrderBy(x => x.ToString());
            foreach (var i in sortedAlphabetically)
            {
                Console.WriteLine(i);
            }

            var largestNumbers = list.OrderByDescending(x => x).Take(5);
            foreach (var i in largestNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
