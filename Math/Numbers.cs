using System;
using System.Linq;
using System.Collections.Generic;

namespace Math.Number
{
    public static class Number
    {
        // Write an algorithm to determine if a number n is happy.

        // A happy number is a number defined by the following process:

        // Starting with any positive integer, replace the number by the sum of the squares of its digits.
        // Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        // Those numbers for which this process ends in 1 are happy.
        // Return true if n is a happy number, and false if not.    
        public bool IsHappyNumber(int n)
        {
            int slow = n;
            int fast = n;

            do
            {
                slow = GetSumOfSquares(slow);
                Console.WriteLine($"Slow: {slow}");

                fast = GetSumOfSquares(fast);
                fast = GetSumOfSquares(fast);
                Console.WriteLine($"Fast: {fast}");

                if (fast == 1)
                    return true;

            } while (slow != fast);

            return slow == 1; 
        }

        // Function to calculate sum of squares of digits
        static int GetSumOfSquares(int num)
        {
            return num.ToString()
                    .Select(digitChar => int.Parse(digitChar.ToString()))
                    .Select(digit => digit * digit)
                    .Sum();
        }
    }
}