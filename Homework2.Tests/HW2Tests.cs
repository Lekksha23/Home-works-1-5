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

        [TestCase(1, "����� ����� � 1-�� �������� =)")]
        [TestCase(2, "����� ����� �� 2-�� �������� =)")]
        [TestCase(3, "����� ����� � 3-�� �������� =)")]
        [TestCase(4, "����� ����� � 4-�� �������� =)")]
        [TestCase(-1, "����� ����� �� ���!")]
        public void CheckAnswerTest(int res, string expected)
        {
            //arrange

            //act
            string actual = _hw2.CheckAnswer(res);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(5)]
        public void CheckAnswerNegativeTest(int res)
        {
            //arrange

            //act, assert
            Assert.Throws(typeof(ArgumentException), () => _hw2.CheckAnswer(res));
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
        
        [TestCase(7, 5, 12)]
        [TestCase(5, 5, 25)]
        [TestCase(5, 7, -2)]
        public void CompareTwoOperandsTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw2.CompareTwoOperands(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5, 1)]
        [TestCase(-3, 3, 2)]
        [TestCase(-5, -5, 3)]
        [TestCase(3, -3, 4)]
        [TestCase(4, 0, -1)]
        [TestCase(0, 0, -1)]
        public void CheckInWhichQuarterDotLiesTest(int x, int y, int expected)
        {
            //arrange

            //act
            int actual = _hw2.CheckInWhichQuarterDotLies(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] {-0.5, -2 }, "� ��������� ��� �����: x1 = -0,5; x2 = -2")]
        [TestCase(new double[] { -1 }, "� ��������� ���� ������: x = -1")]
        public void AnalizeAnswerTest(double[] res, string expected)
        {
            //arrange

            //act
            string actual = _hw2.AnalizeAnswer(res);

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

        [TestCase(0, 13, "��������� ������� �� ����!")]
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

        [TestCase(2, 5, 9, new double[] { -0.5, -2 })]
        [TestCase(2, 4, 0, new double[] { -1 })]
        public void SolveQuadraticEquationTest(int coefA, int coefB, double discr, double[] expected)
        {
            //arrange

            //act
            double[] actual = _hw2.SolveQuadraticEquation(coefA, coefB, discr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-44, 4, 5,"��� ������!")]
        public void SolveQuadraticEquationNegativeTest(double discr, int coefA, int coefB, string expectedMessage)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(Exception), () => _hw2.SolveQuadraticEquation(coefA, coefB, discr));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(55, 71, 30, "30 55 71")]
        [TestCase(71, 55, 30, "30 55 71")]
        [TestCase(71, 30, 55, "30 55 71")]
        [TestCase(30, 71, 55, "30 55 71")]
        [TestCase(55, 30, 71, "30 55 71")]
        [TestCase(30, 55, 71, "30 55 71")]
        public void SortThreeNumbersTest(int a, int b, int c, string expected)
        {
            //arrange
        
            //act
            string actual = _hw2.SortThreeNumbers(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(57, "��������� ����")]
        [TestCase(70, "��������� ")]
        [TestCase(13, "���������� ")]
        public void ConvertIntoWordsTest(int number, string expected)
        {
            //arrange

            //act
            string actual = _hw2.ConvertIntoWords(number);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, "����� ������ ���� ����������!")]
        [TestCase(100, "����� ������ ���� ����������!")]
        public void ConvertIntoWordsNegativeTest(int number, string expectedMessage)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw2.ConvertIntoWords(number));
            Assert.AreEqual(expectedMessage, ex.Message);
        }
    }
}