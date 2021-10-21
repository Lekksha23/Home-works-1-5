using NUnit.Framework;

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

        [TestCase(new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 7, 1, 2, 5}, new int[] { 5, 2, 1, 7})]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        public void ReverseAnArrayTest(int[] array, int[] expected)
        {
            //arrange
            //act
            _hw4.ReverseAnArray(array);

            //assert
            Assert.AreEqual(expected, array);
        }
    }
}