using NUnit.Framework;
using System;

namespace Homework4.Tests
{
    public class HW4Tests
    {
        private HW4 _hw4;

        [SetUp]
        public void Setup()
        {
            _hw4 = new HW4();
        }

        [TestCase(new int[] { 7, 1, 8, 5 }, new int[] { 8, 7, 5, 1 } )]
        [TestCase(new int[] { 5, 5, 5, 5 }, new int[] { 5, 5, 5, 5 } )]
        [TestCase(new int[] { 0 }, new int[] { 0 } )]
        [TestCase(new int[] { }, new int[] { })]
        public void SortAnArrayByInsertionSortTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.SortAnArrayByInsertionSort(array);

            //assert
            Assert.AreEqual(expected, array);
        }

        [TestCase(new int[] { 7, 1, 8, 5 }, new int[] { 1, 5, 7, 8 } )]
        [TestCase(new int[] { 5, 5, 5, 5 }, new int[] { 5, 5, 5, 5 } )]
        [TestCase(new int[] { 0 }, new int[] { 0 } )]
        [TestCase(new int[] { }, new int[] { })]
        public void SortAnArrayBySelectionSortTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.SortAnArrayBySelectionSort(array);

            //assert
            Assert.AreEqual(expected, array);
        }

        [TestCase(new int[] { 7, 3, 8, 5 }, new int[] { 8, 5, 7, 3 } )]
        [TestCase(new int[] { 7, 3, 8, 5, 4 }, new int[] { 5, 4, 8, 7, 3 } )]
        [TestCase(new int[] { 0 }, new int[] { 0 } )]
        [TestCase(new int[] { }, new int[] { })]
        public void SwapFirstAndSecondHalfOfArrayTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.SwapFirstAndSecondHalfOfArray(array);

            //assert
            Assert.AreEqual(expected, array);
        }

        [TestCase(new int[] { 7, 3, 8, 5 }, 3 )]
        [TestCase(new int[] { 7, 3, 8, 5, 3 }, 4 )]
        [TestCase(new int[] { 2, 2, 8, 4, 2 }, 0 )]
        [TestCase(new int[] { 4 }, 0 )]
        [TestCase(new int[] { }, 0)]
        public void CountOddElementsOfArrayTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.CountOddElementsOfArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 7, 1, 2, 5 }, new int[] { 5, 2, 1, 7 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseAnArrayTest(int[] array, int[] expected)
        {
            //arrange

            //act
            _hw4.ReverseAnArray(array);

            //assert
            Assert.AreEqual(expected, array);
        }


        [TestCase(new int[] { 7, 1, 2, 5, 5, 3 }, 9)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, 0)]
        public void CountSumOfElementsWithOddIndexesTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.CountSumOfElementsWithOddIndexes(array);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 7, 6, 10, 20, -5, 23 }, 5)]
        [TestCase(new int[] { 27, 6, 10, 20, -5, 23 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, -1)]
        public void FindIndexOfMaxElementInArrayTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.FindIndexOfMaxElementInArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 6, 10, 20, -5, 23 }, 4)]
        [TestCase(new int[] { -5, 6, 10, 20, 45, 23 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, -1)]
        public void FindIndexOfMinElementInArrayTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.FindIndexOfMinElementInArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 6, 10, 20, -5, 23 }, 23)]
        [TestCase(new int[] { 99, 6, 10, 20, 45, 23 }, 99)]
        [TestCase(new int[] { 0 }, 0)]
        public void FindMaxElementInArrayTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.FindMaxElementInArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, "Массив пустой")]
        public void FindMaxElementInArrayNegativeTest(int[] array, string expectedMessage)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(Exception), () => _hw4.FindMaxElementInArray(array));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        [TestCase(new int[] { 7, 6, 10, 20, -5, 23 }, -5 )]
        [TestCase(new int[] { 99, 6, 10, 20, 45, 23 }, 6 )]
        [TestCase(new int[] { 0 }, 0 )]
        public void FindMinElementInArrayTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.FindMinElementInArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, "Массив пустой")]
        public void FindMinElementInArrayNegativeTest(int[] array, string expectedMessage)
        {
            //arrange

            //act, assert
            Exception ex = Assert.Throws(typeof(Exception), () => _hw4.FindMinElementInArray(array));
            Assert.AreEqual(expectedMessage, ex.Message);
        }
    }
}