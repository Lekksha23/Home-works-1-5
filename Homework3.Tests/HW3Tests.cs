using NUnit.Framework;
using System;

namespace Homework3.Tests
{
    public class HW3Tests
    {
        private HW3 _hw3;

        [SetUp]
        public void Setup()
        {
            _hw3 = new HW3();
        }

        [TestCase(6, 10, 60466176)]
        public void RaiseNumberToPowerTest(int A, int B, double expected)
        {
            //arrange

            //act
            double actual = _hw3.RaiseNumberToPower(A, B);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 0, "Ââåäèòå çíà÷åíèå áîëüøå íóëÿ!")]
        [TestCase(3, -5, "Ââåäèòå çíà÷åíèå áîëüøå íóëÿ!")]
        public void RaiseNumberToPowerNegativeTest(int A, int B, string expectedMessage)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.RaiseNumberToPower(A, B));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(34, 5)]
        [TestCase(1, 0)]
        public void CountSquareOfNumbersLessThanUserNumberTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw3.CountSquareOfNumbersLessThanUserNumber(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-3)]
        public void CountSquareOfNumbersLessThanUserNumberNegativeTest(int a)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.CountSquareOfNumbersLessThanUserNumber(a));
        }

        [TestCase(1000, 500)]
        [TestCase(70, 35)]
        [TestCase(2, 1)]
        public void FindMaxDividorTest(int number, int expected)
        {
            //arrange

            //act
            int actual = _hw3.FindMaxDividor(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-666)]
        [TestCase(0)]
        public void FindMaxDividorNegativeTest(int number)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.FindMaxDividor(number));
        }
 
        [TestCase(70, 35, 315)]
        [TestCase(35, 70, 315)]
        public void CountSumOfNumbersDivisibleBySevenOnUserRangeTest(int numA, int numB, int expected)
        {
            //arrange

            //act
            int actual = _hw3.CountSumOfNumbersDivisibleBySevenOnUserRange(numA, numB);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(30, 30)]
        [TestCase(-49, 0)]
        public void CountSumOfNumbersDivisibleBySevenOnUserRangeNegativeTest(int numA, int numB)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => 
            _hw3.CountSumOfNumbersDivisibleBySevenOnUserRange(numA, numB));
        }

        [TestCase(2, 1)]
        [TestCase(48, 512559680)]
        public void FindNumberOfNumberInFibonacñiRowTest(int n, int expected)
        {
            //arrange

            //act
            int actual = _hw3.FindNumberOfNumberInFibonacñiRow(n);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(49)]
        public void FindNumberOfNumberInFibonacñiRowNegativeTest1(int n)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentOutOfRangeException), () => _hw3.FindNumberOfNumberInFibonacñiRow(n));
        }

        [TestCase(-4)]
        [TestCase(0)]
        public void FindNumberOfNumberInFibonacñiRowNegativeTest2(int n)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.FindNumberOfNumberInFibonacñiRow(n));
        }

        [TestCase(20, 100, 20)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 30, 30)]
        public void FindGreatestCommonDividorTest(int num1, int num2, int expected)
        {
            //arrange

            //act
            int actual = _hw3.FindGreatestCommonDividor(num1, num2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-4, -20)]
        public void FindGreatestCommonDividorNegativeTest(int num1, int num2)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.FindGreatestCommonDividor(num1, num2));
        }

        [TestCase(81, 4.375)]
        public void FindNUsingBinarySearchTest(int x, double expected)
        {
            //arrange

            //act
            double actual = _hw3.FindNUsingBinarySearch(x);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-81)]
        [TestCase(0)]
        public void FindNUsingBinarySearchNegativeTest(int x)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.FindNUsingBinarySearch(x));
        }

        [TestCase(123,"321")]
        [TestCase(333, "333")]
        [TestCase(7, "7")]
        public void MirrorFiguresInNumberTest(int y, string expected)
        {
            //arrange

            //act
            string actual = _hw3.MirrorFiguresInNumber(y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void MirrorFiguresInNumberNegativeTest(int x)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw3.MirrorFiguresInNumber(x));
        }

        [TestCase(1234567, 4)]
        [TestCase(-34576, 3)]
        public void CountOddFiguresInNumberTest(int numberA, int expected)
        {
            //arrange

            //act
            int actual = _hw3.CountOddFiguresInNumber(numberA);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, "100 200 300 400 500 600 700 800 900 1000 ")]
        [TestCase(-100, "100 200 300 400 500 600 700 800 900 1000 ")]
        [TestCase(51, "51 102 153 204 255 306 357 408 459 510 561 612 663 714 765 816 867 918 969 ")]
        public void FindNumbersDivisibleByUserNumberInRangeTest(int num, string expected)
        {
            //arrange

            //act
            string actual = _hw3.FindNumbersDivisibleByUserNumberInRange(num);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void FindNumbersDivisibleByUserNumberInRangeNegativeTest(int num)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(DivideByZeroException), () => _hw3.FindNumbersDivisibleByUserNumberInRange(num));
        }

        [TestCase(0, "")]
        [TestCase(77, "2 4 6 8 12 14 16 18 20 21 22 24 26 28 34 36 38 40 41 42 43 44 46 48 56 58 60 61 62 63 64 65 66 68 ")]
        public void FindInWhichNumbersSumOfEvenFiguresGreaterThanSumOfOddFiguresInRangeBeforeUserNumberTest(int num, string expected)
        {
            //arrange

            //act
            string actual = _hw3.FindInWhichNumbersSumOfEvenFiguresGreaterThanSumOfOddFiguresInRangeBeforeUserNumber(num);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1)]
        public void FindInWhichNumbersSumOfEvenFiguresGreaterThanSumOfOddFiguresInRangeBeforeUserNumberNegativeTest(int num)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () =>
            _hw3.FindInWhichNumbersSumOfEvenFiguresGreaterThanSumOfOddFiguresInRangeBeforeUserNumber(num));
        }

        [TestCase(123, 345, "ÄÀ")]
        [TestCase(345, 111, "ÍÅÒ")]
        [TestCase(-3666, -345, "ÄÀ")]
        public void CheckNumbersForSameFiguresTest(int numN1, int numN2, string expected)
        {
            //arrange

            //act
            string actual = _hw3.CheckNumbersForSameFigures(numN1, numN2);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}