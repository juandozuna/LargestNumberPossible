using NUnit.Framework;
using System;
namespace LargestNumberPossible
{
    [TestFixture()]
    public class Test
    {

        [Test()]
        public void LargestNumberEmptyArray()
        {

            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("", largest.GetLargest(new int[] { }));

        }

        [Test()]
        public void LargestNumberWithNegativeNumbers()
        {

            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("", largest.GetLargest(new int[] { -1, -3, 9, -7, 5 }));
        }

        [Test()]
        public void ArrayWithSingleDigitNumber()
        {
            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("2", largest.GetLargest(new int[] { 2 }));
        }

        [Test()]
        public void ArratWithSingleTwoDigitNUmber()
        {
            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("34", largest.GetLargest(new int[] { 34 }));
        }

        [Test()]
        public void ArrayWithTwoNumbersOneSingleDigit()
        {
            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("32", largest.GetLargest(new int[] { 2, 3 }));

        }
        [Test()]
        public void ArrayWithTwoNumbersOneSingleDigitDifernets()
        {
            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("43", largest.GetLargest(new int[] { 4, 3 }));

        }

        [Test()]
        public void ArrayWithOneTwoDigitNumberAndOneDigitNumber()
        {
            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("934", largest.GetLargest(new int[] { 34, 9 }));
        }

        [Test()]
        public void ArrayWithTwoTwoDigitNumber()
        {
            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("3429", largest.GetLargest(new int[] { 34, 29 }));
        }

        [Test()]
        public void ArrayWithThreeSingleDigitNumbers()
        {
            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("421", largest.GetLargest(new int[] { 2, 1, 4 }));
        }

        [Test]
        public void ArrayWithOneTwoDigitNumbersAndTwoOneDigitNumber()
        {
            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("4332", largest.GetLargest(new int[] { 2, 33, 4 }));
        }

        [Test()]
        public void ArrayWithFourNumbers()
        {
            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("992854", largest.GetLargest(new int[] { 8, 92, 54, 9 }));
        }

        [Test()]
        public void AllArrayNumbersAreZero()
        {
            LargestNumber number = new LargestNumber();
            Assert.AreEqual("0", number.GetLargest(new int[] { 0, 0, 0, 0, 0, 0 }));
        }

        [Test()]
        public void ArrayWithNormalInputForGeneralFinishCase()
        {
            LargestNumber largest = new LargestNumber();
            Assert.AreEqual("987654321100", largest.GetLargest(new int[] { 1, 2, 3, 4, 7, 8, 5, 6, 10, 0, 9 }));
        }




        

    }
}
