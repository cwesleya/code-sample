using System;

namespace code_sample
{
    public static class Sums
    {
        /// <summary>
        /// O(1) operation: returns the sum of all integers from startRange to endRange inclusive
        /// </summary>
        /// <param name="startRange"></param>
        /// <param name="endRange"></param>
        /// <returns>int</returns>
        public static int SumRange(int startRange, int endRange)
        {
            int sum = (endRange * ++endRange) >> 1;

            return startRange > 1 ? sum - SumRange(0, --startRange) : sum;
        }
        /// <summary>
        /// Returns the sum of all even integers from startRange to endRange inclusive
        /// </summary>
        /// <param name="startRange"></param>
        /// <param name="endRange"></param>
        /// <returns>int</returns>
        public static int SumRangeEven(int startRange, int endRange)
        {
            if (startRange > endRange)
                return 0;

            if (startRange % 2 != 0)
                startRange++;
            if (endRange % 2 != 0)
                endRange--;

            int size = (endRange - startRange) >> 1;
            int sumEven = ++size * (startRange + endRange) >> 1;

            return sumEven; 
        }
        /// <summary>
        /// Returns the sum of all odd integers from startRange to endRange inclusive
        /// </summary>
        /// <param name="startRange"></param>
        /// <param name="endRange"></param>
        /// <returns>int</returns>
        public static int SumRangeOdd(int startRange, int endRange)
        {
            int sumTotal = SumRange(startRange, endRange);
            int sumEven = SumRangeEven(startRange, endRange);

            return sumTotal - sumEven;
        }
    }
}