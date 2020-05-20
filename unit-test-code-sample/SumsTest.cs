using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.IO;
using code_sample;
using System;

namespace unit_test_code_sample
{
    [TestClass]
    public class SumsTest
    {
        private Random _randomInt = new Random();
        private int _start;
        private int _end;

        public SumsTest()
        {
            _start = _randomInt.Next(2, 50);
            _end = _randomInt.Next(50, 100);
        }

        private static int _manualCalculateSumRangeOdd(int start, int end)
        {
            int sum = 0;

            if (start % 2 == 0)
                start++;

            while (start <= end)
            {
                sum += start;
                start += 2;
            }

            return sum;
        }

        private static int _manualCalculateSumRangeEven(int start, int end)
        {
            int sum = 0;

            if (start % 2 != 0)
                start++;

            while (start <= end)
            {
                sum += start;
                start += 2;
            }

            return sum;
        }

        private static int _manualCalculateSumRange(int start, int end)
        {
            int sum = 0;

            while (start <= end)
            {
                sum += start++;
            }

            return sum;
        }

        [TestMethod]
        public void SumRangeTestStartAtRandom()
        {
            int manualCalculation = _manualCalculateSumRange(_start, _end);
            int result = Sums.SumRange(_start, _end);

            Assert.AreEqual(result, manualCalculation);
        }

        [TestMethod]
        public void SumRangeTestStartAtZero()
        {
            int manualCalculation = _manualCalculateSumRange(0, 100);
            int result = Sums.SumRange(0, 100);

            Assert.AreEqual(manualCalculation, result);
        }

        [TestMethod]
        public void SumRangeTestStartAtOne()
        {
            int manualCalculation = _manualCalculateSumRange(0, 100);
            // The sum from 0 to N should equal sum from 1 to N
            Assert.AreEqual(manualCalculation, Sums.SumRange(1, 100));
        }

        [TestMethod]
        public void SumRangeTestNegativeRange()
        {
            Assert.AreEqual(0, Sums.SumRange(10, 9));
        }

        //Even
        [TestMethod]
        public void SumRangeEvenTestStartAtRandom()
        {
            int manualCalculation = _manualCalculateSumRangeEven(_start, _end);
            int result = Sums.SumRangeEven(_start, _end);

            Assert.AreEqual(result, manualCalculation);
        }

        [TestMethod]
        public void SumRangeEvenTestStartAtZero()
        {
            int manualCalculation = _manualCalculateSumRangeEven(0, 100);
            int result = Sums.SumRangeEven(0, 100);

            Assert.AreEqual(manualCalculation, result);
        }

        [TestMethod]
        public void SumRangeEvenTestStartAtOne()
        {
            int manualCalculation = _manualCalculateSumRangeEven(0, 100);
            
            Assert.AreEqual(manualCalculation, Sums.SumRangeEven(1, 100));
        }

        [TestMethod]
        public void SumRangeEvenTestNegativeRange()
        {
            Assert.AreEqual(0, Sums.SumRangeEven(10, 9));
        }

        //Odd
        [TestMethod]
        public void SumRangeOddTestStartAtRandom()
        {
            int manualCalculation = _manualCalculateSumRangeEven(_start, _end);
            int result = Sums.SumRangeEven(_start, _end);

            Assert.AreEqual(result, manualCalculation);
        }

        [TestMethod]
        public void SumRangeOddTestStartAtZero()
        {
            int manualCalculation = _manualCalculateSumRangeOdd(0, 100);
            int result = Sums.SumRangeOdd(0, 100);

            Assert.AreEqual(manualCalculation, result);
        }

        [TestMethod]
        public void SumRangeOddTestStartAtOne()
        {
            int manualCalculation = _manualCalculateSumRangeOdd(0, 100);

            Assert.AreEqual(manualCalculation, Sums.SumRangeOdd(1, 100));
        }

        [TestMethod]
        public void SumRangeOddTestNegativeRange()
        {
            Assert.AreEqual(0, Sums.SumRangeOdd(10, 9));
        }
    }
}