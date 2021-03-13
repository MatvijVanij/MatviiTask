using NUnit.Framework;
using System;

namespace TaskMatvii.Tests
{
    class CyclesTests
    {
        [TestCase(4, 1, 4)]
        [TestCase(-1, 7, -1)]
        [TestCase(9, 5, 59049)]
        [TestCase(2, 10, 1024)]
        [TestCase(4, 0, 1)]
        [TestCase(0, 3, 0)]
        [TestCase(1, -1, 1)]
        [TestCase(2, -2, 0.25)]
        public void Exponentiation_WhenARaiseToB_ShouldAMultipliedBTimes(double a, double b, double expected)
        {
            double actual = Cycles.Exponentiation(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Exponentiation_WhenBNegativeAndAEquvellZero_ShouArgumentExceptin()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Cycles.Exponentiation(0, -4);
            });
        }

        [TestCase(2, 10, new int[] { 2, 4, 6, 8, 10 })]
        [TestCase(50, 100, new int[] { 50, 100 })]
        [TestCase(30, 100, new int[] { 30, 60, 90 })]
        public void OutputNumbersDivisibleA_WhenADivider_ShouldReturnArrayValueDividedIntoARangeFromZeroToB(int a, int b, int[] expected)
        {
            int[] actual = Cycles.OutputNumbersDivisibleA(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OutputNumbersDivisibleA_WhenAEquvellZero_ShoudDividedByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                Cycles.OutputNumbersDivisibleA(0, 19);
            });
        }

        [TestCase(4, -4)]
        [TestCase(4, 1001)]
        public void OutputNumbersDivisibleA_WhenBbigerOneThousandAndLessOne_ShoudBOutOfTheRenge(int a, int b)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Cycles.OutputNumbersDivisibleA(a, b);
            });
        }

        [TestCase(100, 10)]
        [TestCase(10, 4)]
        [TestCase(50, 8)]
        [TestCase(1, 1)]
        public void OutputPrintPositiveIntegersSquare_WhenAIsDianazonBorder_ShouldCountValueSquareLessA(int a, int expected)
        {
            int actual = Cycles.OutputPrintPositiveIntegersSquare(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-4)]
        public void OutputNumbersDivisibleA_WhenALessZero_ShoudArgumentOutOfRangeException(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Cycles.OutputPrintPositiveIntegersSquare(a);
            });
        }

        [TestCase(57, 19)]
        [TestCase(100, 50)]
        [TestCase(21, 7)]
        [TestCase(28, 14)]
        public void PrintGreatestВivisor_WhenAIsBiggerDivider_ShouldBiggerFrontA(int a, int expected)
        {
            int actual = Cycles.PrintGreatestВivisor(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-4)]
        [TestCase(-323)]
        public void PrintGreatestВivisor_WhenALessZero_ShoudArgumentOutOfRangeException(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Cycles.PrintGreatestВivisor(a);
            });
        }

        [TestCase(0, 22, 42)]
        [TestCase(7, -7, 0)]
        [TestCase(-8, 15, 14)]
        [TestCase(1, 5, 0)]
        public void DisplaySumOfNumbers_WhenValueForRangeABDividedBySeven_ShouldSumAllVariebls(int a, int b, int expected)
        {
            int actual = Cycles.DisplaySumOfNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(10, 55)]
        [TestCase(18, 2584)]
        [TestCase(22, 17711)]
        public void PrintNumberOfFibonacci_WhenAIselementLineFibonacci_ShouldValueIsElements(int a, int expected)
        {
            int actual = Cycles.PrintNumberOfFibonacci(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-41)]
        public void PrintNumberOfFibonacci_WhenAIsLeesZero_ShouldArgumentOutOfRangeException(int a)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Cycles.PrintNumberOfFibonacci(a);
            });
        }

        [TestCase(13, 26, 13)]
        [TestCase(10, 55, 5)]
        [TestCase(34, 51, 17)]
        [TestCase(22, 1, 1)]

        public void DivisorUsingEuclidAlgorithm_WhenAandBPassed_ShouldReternBiggerDivider(int a, int b, int expected)
        {
            int actual = Cycles.DivisorUsingEuclidAlgorithm(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, -3)]
        [TestCase(-41, -4)]
        [TestCase(0, 0)]
        public void DivisorUsingEuclidAlgorithm_WhenAAndBLessOrEquelZero_ShouldArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Cycles.DivisorUsingEuclidAlgorithm(a, b);
            });
        }

        [TestCase(125, 5)]
        [TestCase(27, 3)]
        [TestCase(343, 7)]
        [TestCase(1, 1)]
        public void BinarySearch_WhenAPassed_ShouldReternCubeRoot(int a, int expected)
        {
            int actual = Cycles.BinarySearch(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-41)]
        [TestCase(0)]
        public void BinarySearch_WhenALessZero_ShouldArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Cycles.BinarySearch(a);
            });
        }

        [TestCase(125234, 3)]
        [TestCase(12013213, 5)]
        [TestCase(123456789, 5)]
        [TestCase(1, 1)]
        [TestCase(-12013213, 5)]
        [TestCase(0, 0)]
        public void FindCountOddElements_WhenAPassed_ShouldReternQuantityOddElements(int a, int expected)
        {
            int actual = Cycles.FindCountOddElements(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(125234, 432521)]
        [TestCase(0, 0)]
        [TestCase(123456789, 987654321)]
        [TestCase(1, 1)]
        public void FindNumberThatMirrorImage_WhenAPassed_ShouldReternQuantityOddElementsMirrorNumber(int a, int expected)
        {
            int actual = Cycles.FindNumberThatMirrorImage(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-4341)]
        public void FindNumberThatMirrorImage_WhenALessZero_ShouldArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Cycles.FindNumberThatMirrorImage(a);
            });
        }

        [TestCase(12, new int[] { 2, 4, 6, 8, 12 })]
        [TestCase(5, new int[] { 2, 4 })]
        [TestCase(20, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20 })]
        [TestCase(1, new int[] { })]
        public void PrintNumbersSumEvenDigitsSumOddOnes_WhenAPassed_ShouldReterntheSumEvenGreaterThanOddSum(int a, int[] expected)
        {
            int[] actual = Cycles.PrintNumbersSumEvenDigitsSumOddOnes(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-23)]
        [TestCase(0)]
        public void PrintNumbersSumEvenDigitsSumOddOnes_WhenAnegative_ShouldRetern(int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Cycles.PrintNumbersSumEvenDigitsSumOddOnes(a);
            });
        }

        [TestCase(125234, 43252, true)]
        [TestCase(0, 1, false)]
        [TestCase(123456789, 98765432, true)]
        [TestCase(1, 1, true)]
        [TestCase(-1, 1, true)]
        [TestCase(-125234, -43252, true)]
        [TestCase(123456, 78906, true)]
        [TestCase(171, 8671, true)]
        public void CheckDuplicateNumbers_WhenAandBPassed_ShouldReternYasorNoSameNumbers(int a, int b, bool expected)
        {
            bool actual = Cycles.CheckDuplicateNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}