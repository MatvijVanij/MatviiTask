using NUnit.Framework;

namespace TaskMatvii.Tests
{
    public class SecondArraysTests
    {
        [TestCase(1, 1)]
        [TestCase(2, -9)]
        [TestCase(3, -8)]
        public void OutputMinElementsSecondArrays_WhenAraaysLoaded_ShoudReternMinElements(int mockNumber, int expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);

            int actual = SecondArray.OutputMinElementsSecondArrays(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, -1)]
        [TestCase(3, 9)]
        public void OutputMaxElementsSecondArrays_WhenAraaysLoaded_ShoudReternMaxElements(int mockNumber, int expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);

            int actual = SecondArray.OutputMaxElementsSecondArrays(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 0, 0 })]
        [TestCase(2, new int[] { 2, 2 })]
        [TestCase(3, new int[] { 2, 1 })]
        public void OutputIndexMinElementsSecondArrays_WhenAraaysLoaded_ShoudReternIndexMinElements(int mockNumber, int[] expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);

            int[] actual = SecondArray.OutputIndexMinElementsSecondArrays(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 2, 2 })]
        [TestCase(2, new int[] { 0, 0 })]
        [TestCase(3, new int[] { 2, 2 })]
        public void OutputIdexMaxElementsSecondArrays_WhenAraaysLoaded_ShoudReternIndexMaxElements(int mockNumber, int[] expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);

            int[] actual = SecondArray.OutputIdexMaxElementsSecondArrays(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 4)]
        [TestCase(2, 5)]
        [TestCase(3, 6)]
        public void OutputTransposeMatrix_WhenAraaysLoaded_ShoudReternTransposeMatrix(int mockNumber, int mockNumber1)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);

            int[,] expected  = DoubleArrayMock.GetMock(mockNumber1);

            int[,] actual = SecondArray.OutputTransposeMatrix(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 0)]
        public void FindingNumberMaxElementsSecond_WhenAraaysLoaded_ShoudReternCountsBiggestElementsForNeighbors(int mockNumber, int expected)
        {
            int[,] array = DoubleArrayMock.GetMock(mockNumber);

            int actual = SecondArray.FindingNumberMaxElementsSecond(array);

            Assert.AreEqual(expected, actual);
        }

    }

    public static class DoubleArrayMock
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result = new int[,]
                    {
                        {1,2,3 },
                        {4,5,6 },
                        {7,8,9 }
                    };
                    break;
                case 2:
                    result = new int[,]
                    {
                        {-1,-2,-3 },
                        {-4,-5,-6 },
                        {-7,-8,-9 }
                    };
                    break;
                case 3:
                    result = new int[,]
                    {
                        {1,2,0 },
                        {-4,5,-6 },
                        {7,-8,9 },
                        {7,-8,9 }
                    };
                    break;
                case 4:
                    result = new int[,]
                    {
                        {1,4,7 },
                        {2,5,8 },
                        {3,6,9 },
                    };
                    break;
                case 5:
                    result = new int[,]
                    {
                        {-1,-4,-7 },
                        {-2,-5,-8 },
                        {-3,-6,-9 },
                    };
                    break;
                case 6:
                    result = new int[,]
                    {
                        {1,-4,7,7 },
                        {2,5,-8,-8},
                        {0,-6,9,9 },
                    };
                    break;

            }
            return result;
        }
    }

}

