using NUnit.Framework;
using System;

namespace TaskMatvii.Tests
{
    public class VariablesTest
    {
        [TestCase(2, 3, 19)]
        [TestCase(0, 5, 5)]
        [TestCase(4, 0, -5)]
        [TestCase(10, 4, -11)]
        public void SolvingEquations_WhenABSubstituteInEquation_ShouldSolveEquation(int a, int b, int expected)
        {
            int actual = Variables.SolvingEquations(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(-1, -1)]
        public void SolvingEquations_WhenAEqualB_ShouldThrowDividedByZeroException(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                Variables.SolvingEquations(a, b);
            });
        }

        [TestCase(2, 3, 3, 2)]
        [TestCase(0, 5, 5, 0)]
        [TestCase(4, -3, -3, 4)]
        [TestCase(10, 4, 4, 10)]
        public void SwapOfValuesOfValues_WhenSwapAB_ShouldReturnBA(int a, int b, int expectedA, int expectedB)
        {
            Variables.SwapOfValues(ref a, ref b);

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        }

        [TestCase(2, 2, new int[] { 1, 0 })]
        [TestCase(5, 2, new int[] { 2, 1 })]
        [TestCase(17, 5, new int[] { 3, 2 })]
        [TestCase(-21, 10, new int[] { -2, -1 })]
        public void DivisionAndRemainderDivision_WhenValidABPassed_ShouldReturnDivisionAndRemainder(int a, int b, int[] expected)
        {
            int[] actual = Variables.DivisionAndRemainderDivision(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivisionAndRemainderDivision_WhenBEqualZero_ShouldThrowDividedByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                Variables.DivisionAndRemainderDivision(5, 0);
            });
        }

        [TestCase(1, 2, 3, 1)]
        [TestCase(2, 5, 5, 0)]
        [TestCase(4, 0, 8, 2)]
        [TestCase(-2, 4, 12, -4)]
        public void SolvingLinearEquation_WhenAandBandCSubstituteInEquation_ShouldlinearEquationSolution(int a, int b, int c, int expected)
        {
            int actual = Variables.SolvingLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 3)]
        [TestCase(0, 0, 0)]
        public void SolvingLinearEquation_WhenAEqualZero_ShouldThrowDividedByZeroException(int a, int b, int c)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                Variables.SolvingLinearEquation(a, b, c);
            });
        }

        [TestCase(1, 1, 2, 2, new int[] { 1, 0 })]
        [TestCase(0, -2, 2, 6, new int[] { 4, -2 })]
        [TestCase(5, 10, 10, 5, new int[] { -1, 15 })]
        [TestCase(4, 1, 7, 2, new int[] { 0, 1 })]
        public void MappinglineEquationTests_WhenKeepCoordinates2Points_ShoudEquationOfStraightLine(int x1, int y1, int x2, int y2, int[] expected)
        {
            int[] actual = Variables.MappingLineEquation(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 0, 3)]
        [TestCase(1, 6, 1, -4)]
        [TestCase(-4, 6, -4, 7)]
        public void MappinglineEquationTests_WhenX1eqwelX2_ShoudReturnArgumentException(int x1, int y1, int x2, int y2)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Variables.MappingLineEquation(x1, y1, x2, y2);
            });
        }
    }
}