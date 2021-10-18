using NUnit.Framework;
using System;

namespace Homework1.Tests
{
    public class HW1Tests
    {
        private HW1 _hw1;

        [SetUp]
        public void Setup()
        {
            _hw1 = new HW1();
        }


        [TestCase(5, 7, 37)]
        [TestCase(3, 3.5, 54.5)]
        public void CalcFormulaTest(double a, double b, double expected)
        {
            //arrange

            //act
            double actual = _hw1.CalcFormula(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase (300, 300)]
        public void CalcFormulaNegativeTest(double a, double b)
        {
            //arrange

            //act, assert
            Assert.Throws(typeof(ArgumentException), () => _hw1.CalcFormula(a, b));
        }

        [TestCase(1, 5, 3, -2)]
        public void CalcFormula2Test(int a, int b,  int c, double expected)
        {
            //arrange

            //act
            double actual = _hw1.CalcFormula2(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 7, 3)]
        public void CalcFormula2NegativeTest(int a, int b, int c)
        {
            //arrange

            //act, assert
            Assert.Throws(typeof(DivideByZeroException), () => _hw1.CalcFormula2(a, b, c));
        }

        [TestCase(3, 7, 6, 1, -2)]
        public void CalcCoefKTest(int x1, int y1, int x2, int y2, double expected)
        {
            //arrange

            //act
            double actual = _hw1.CalcCoefK(x1, y1, x2, y2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 6, 6, 6)]
        public void CalcCoefKNegativeTest(int x1, int y1, int x2, int y2)
        {
            //arrange

            //act, assert
            Assert.Throws(typeof(DivideByZeroException), () => _hw1.CalcCoefK(x1, y1, x2, y2));
        }

        [TestCase(-2, 6, 1, 13)]
        public void CalcCoefBTest(int coefK, int x2, int y2, double expected)
        {
            //arrange

            //act
            double actual = _hw1.CalcCoefB(coefK, x2, y2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2, 1.5)]
        public void DivideFirstOperandBySecondTest(int a, int b, double expected)
        {
            //arrange

            //act
            double actual = _hw1.DivideFirstOperandBySecond(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 0)]
        public void DivideFirstOperandBySecondNegativeTest(int a, int b)
        {
            //arrange

            //act, assert
            Assert.Throws(typeof(DivideByZeroException), () => _hw1.DivideFirstOperandBySecond(a, b));
        }

        [TestCase(30, 20, 10)]
        public void CalcRemainderOfDivisionTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw1.CalcRemainderOfDivision(a, b);

            //asert
            Assert.AreEqual(expected, actual);
        }

        //[TestCase(23, 4, 37)]

        //public void SwapTwoStringVariablesTest(string a, string b, string expected)
        //{
        //    //arrange

        //    //
        //    string tmp = a;
        //    a = b;
        //    b = tmp;

        //    string actual = 

        ////assert
        //Assert.AreEqual(expected, actual);
        //}
    }
}