using NUnit.Framework;
using System;

namespace Homework2.Tests
{
    public class HW2Tests
    {
        private HW2 _hw2;

        [SetUp]
        public void Setup()
        {
            _hw2 = new HW2();
        }

        [TestCase(5, 34, 39)]
        public void SumTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw2.Sum(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 34, -29)]
        public void SubtractTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw2.Subtract(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 7, 35)]
        public void MultiplyTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw2.Multiply(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5, 1)]
        [TestCase(-3, 3, 2)]
        [TestCase(-5, -5, 3)]
        [TestCase(3, -3, 4)]
        [TestCase(4, 0, -666)]
        [TestCase(0, -4, -666)]
        [TestCase(0, 0, -666)]
        public void CheckInWhichQuarterDotLiesTest(int x, int y, int expected)
        {
            //arrange

            //act
            int actual = _hw2.CheckInWhichQuarterDotLies(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, 2, 9)]
        public void CalcDiscrTest(int coefA, int coefB, int coefC, double expected)
        {
            //arrange

            //act
            double actual = _hw2.CalcDiscr(coefA, coefB, coefC);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 2, 5, -0.5)]
        public void CalcX1Test(double discr, int coefA, int coefB, double expected)
        {
            //arrange

            //act
            double actual = _hw2.CalcX1(discr, coefA, coefB);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0)]
        public void CalcX1NegativeTest(double discr, int coefA, int coefB)
        {
            //arrange

            //act, assert
            Assert.Throws(typeof(DivideByZeroException), () => _hw2.CalcX1(discr, coefA, coefB));
        }

        [TestCase(9, 2, 5, -2)]
        public void CalcX2Test(double discr, int coefA, int coefB, double expected)
        {
            //arrange

            //act
            double actual = _hw2.CalcX2(discr, coefA, coefB);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 7, -1.75)]
        public void CalcXTest(int coefA, int coefB, double expected)
        {
            //arrange

            //act
            double actual = _hw2.CalcX(coefA, coefB);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 13, "Произошло деление на ноль!")]
        public void CalcXNegativeTest(int coefA, int coefB, string expectedMessage)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(DivideByZeroException), () => _hw2.CalcX(coefA, coefB));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 0, 0)]
        public void CalcX2NegativeTest(double discr, int coefA, int coefB)
        {
            //arrange

            //act, assert
            Assert.Throws(typeof(DivideByZeroException), () => _hw2.CalcX2(discr, coefA, coefB));
        }

        [TestCase(55, 71, 30)]
        public void SortThreeNumbersTest(int a, int b, int c)
        {
            //arrange
            string expected = $"{c} {a} {b}";
            //act
            string actual = _hw2.SortThreeNumbers(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(57, "Пятьдесят семь")]
        [TestCase(13, "Тринадцать ")]
        public void ConvertIntoWordsTest(int number, string expected)
        {
            //arrange

            //act
            string actual = _hw2.ConvertIntoWords(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, "Число должно быть двузначным!")]
        [TestCase(100, "Число должно быть двузначным!")]
        public void ConvertIntoWordsNegativeTest(int number, string expectedMessage)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw2.ConvertIntoWords(number));
            Assert.AreEqual(expectedMessage, ex.Message);
        }
    }
}