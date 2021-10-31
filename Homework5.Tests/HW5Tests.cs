using NUnit.Framework;
using System;

namespace Homework5.Tests
{
    public class HW5Tests
    {
        private HW5 _hw5;

        [SetUp]
        public void Setup()
        {
            _hw5 = new HW5();
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(-1)]
        public void TransposeTheMatrixTest(int index)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForTransposeTheMatrixTest(index);
            int[,] expected = TestData.GetExpectedArrayForTransposeTheMatrixTest(index);

            //act
            _hw5.TransposeTheMatrix(arrayToTest);

            //assert
            Assert.AreEqual(expected, arrayToTest);
        }

        [TestCase(0, 2)]
        [TestCase(1, 2)]
        [TestCase(2, 0)]
        [TestCase(-1, 0)]
        public void CountSumOfElementsThatGreaterThanNeighborsTest(int index, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForCountSumOfElementsThatGreaterThanNeighborsTest(index);

            //act
            int actual = _hw5.CountSumOfElementsThatGreaterThanNeighbors(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, new int[] { 0, 1})]
        [TestCase(1, new int[] { 1, 1})]
        [TestCase(2, new int[] { 0, 0})]
        public void FindIndexOfMaxElementInDoubleArrayTest(int index, int[] expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFindIndexOfMaxElementInDoubleArrayTest(index);

            //act
            int[] actual = _hw5.FindIndexOfMaxElementInDoubleArray(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1, "Массив не должен быть пустым!")]
        public void FindIndexOfMaxElementInDoubleArrayNegativeTest(int index, string expectedMessage)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFindIndexOfMaxElementInDoubleArrayTest(index);

            //act, assert
            Exception ex = Assert.Throws(typeof(Exception), () => _hw5.FindIndexOfMaxElementInDoubleArray(arrayToTest));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, new int[] { 0, 0 })]
        [TestCase(1, new int[] { 0, 2 })]
        [TestCase(2, new int[] { 0, 0 })]
        public void FindIndexOfMinElementInDoubleArrayTest(int index, int[] expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFindIndexOfMinElementInDoubleArrayTest(index);

            //act
            int[] actual = _hw5.FindIndexOfMinElementInDoubleArray(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1, "Массив не должен быть пустым!")]
        public void FindIndexOfMinElementInDoubleArrayNegativeTest(int index, string expectedMessage)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFindIndexOfMinElementInDoubleArrayTest(index);

            //act, assert
            Exception ex = Assert.Throws(typeof(Exception), () => _hw5.FindIndexOfMinElementInDoubleArray(arrayToTest));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(0, 11)]
        [TestCase(1, 53)]
        [TestCase(2, 12)]
        [TestCase(3, 0)]
        public void FindMaxElementInDoubleArrayTest(int index, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFindMaxElementInDoubleArrayTest(index);

            //act
            int actual = _hw5.FindMaxElementInDoubleArray(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 10)]
        [TestCase(1, 12)]
        [TestCase(2, 12)]
        [TestCase(3, 0)]
        public void FindMinElementInDoubleArrayTest(int index, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFindMinElementInDoubleArrayTest(index);

            //act
            int actual = _hw5.FindMinElementInDoubleArray(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}