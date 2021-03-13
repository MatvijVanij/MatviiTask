using System;
using NUnit.Framework;

namespace TaskMatvii.Tests
{
    public class OneArraysTests
    {
        [TestCase(new int[] { 1, 1, 4, 0 }, 0)]
        [TestCase(new int[] { -5, -1, 3 }, -5)]
        [TestCase(new int[] { -14, 1, 2 }, -14)]
        [TestCase(new int[] { -10, 0, 4 }, -10)]
        public void OutputMinElementsArray_WhenAraaysLoaded_ShoudReternMinElementArrays(int[] a, int expected)
        {
            int actual = OneArrays.OutputMinElementsArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void OutputMinElementsArray_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                OneArrays.OutputMinElementsArray(array);
            });
        }

        [TestCase(new int[] { 1, 1, 4, 0 }, 4)]
        [TestCase(new int[] { -5, -1, 3 }, 3)]
        [TestCase(new int[] { -14, 1, 2 }, 2)]
        [TestCase(new int[] { -10, 0, -4 }, 0)]
        public void OutputMaxElementsArray_WhenAraaysLoaded_ShoudReternMaxElementArrays(int[] a, int expected)
        {
            int actual = OneArrays.OutputMaxElementsArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void OutputMaxElementsArray_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                OneArrays.OutputMaxElementsArray(array);
            });
        }

        [TestCase(new int[] { 1, 1, 4, 0 }, 2)]
        [TestCase(new int[] { -5, -1, 3, 8 }, 3)]
        [TestCase(new int[] { 100, -14, -101, 2 }, 0)]
        [TestCase(new int[] { -10, 0, -4000, -9000 }, 1)]
        public void OutputIndexMaxElementsArray_WhenAraaysLoaded_ShoudReternIndexMaxElementArrays(int[] a, int expected)
        {
            int actual = OneArrays.OutputIndexMaxElementsArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void OutputIndexMaxnElementsArray_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                OneArrays.OutputIndexMaxElementsArray(array);
            });
        }

        [TestCase(new int[] { 1, 1, 4, 0, -1 }, 4)]
        [TestCase(new int[] { -5, -1, 3, 8 }, 0)]
        [TestCase(new int[] { 100, 1, -100, 0, -1 }, 2)]
        [TestCase(new int[] { -10, 0, -4000, -9000 }, 3)]
        public void OutputIndexMinElementsArray_WhenAraaysLoaded_ShoudReternIndexMinElementArrays(int[] a, int expected)
        {
            int actual = OneArrays.OutputIndexMinElementsArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void OutputIndexMinElementsArray_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                OneArrays.OutputIndexMinElementsArray(array);
            });
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 20)]
        [TestCase(new int[] { -5, -1, 3, 8 }, 7)]
        [TestCase(new int[] { 100, -14, -101, 2 }, -12)]
        [TestCase(new int[] { -10, 0, -4000, -9000 }, -9000)]
        public void CalculateSumArrayElementsIsOddIndex_WhenAraaysLoaded_ShoudReternSumElementsWhyIndexOdd(int[] a, int expected)
        {
            int actual = OneArrays.CalculateSumArrayElementsIsOddIndex(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void CalculateSumArrayElementsIsOddIndex_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                OneArrays.CalculateSumArrayElementsIsOddIndex(array);
            });
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { -5, -1, 3, 8 }, new int[] { 8, 3, -1, -5 })]
        [TestCase(new int[] { 100, 0, -101, 2 }, new int[] { 2, -101, 0, 100 })]
        [TestCase(new int[] { -10, 0, -4000, -9000 }, new int[] { -9000, -4000, 0, -10 })]
        public void OutputReverseArray_WhenAraaysLoaded_ShoudReternReversInputArray(int[] a, int[] expected)
        {
            int[] actual = OneArrays.OutputReverseArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void OutputReverseArray_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                OneArrays.OutputReverseArray(array);
            });
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5)]
        [TestCase(new int[] { -5, -1, 3, 8 }, 3)]
        [TestCase(new int[] { 100, -14, -101, 2 }, 1)]
        [TestCase(new int[] { -10, 0, -4000, -9000 }, 0)]
        public void CountNumberOddElementsArray_WhenAraaysLoaded_ShoudReternCountsOddElements(int[] a, int expected)
        {
            int actual = OneArrays.CountNumberOddElementsArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void CountNumberOddElementsArray_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                OneArrays.CountNumberOddElementsArray(array);
            });
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 6, 7, 8, 9, 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { -5, -1, 3, 8 }, new int[] { 3, 8, -5, -1 })]
        [TestCase(new int[] { 100, 0, -101, 2 }, new int[] { -101, 2, 100, 0 })]
        [TestCase(new int[] { -10, 0, -4000, -9000, 1 }, new int[] { -9000, 1, -4000, -10, 0 })]
        public void ChangeArrayOfMidl_WhenAraaysLoaded_ShoudReternReversArrayForMidl(int[] a, int[] expected)
        {
            int[] actual = OneArrays.ChangeArrayOfMidl(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void ChangeArrayOfMidl_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                OneArrays.ChangeArrayOfMidl(array);
            });
        }

        [TestCase(new int[] { 6, 7, 8, 9, 5, 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [TestCase(new int[] { -5, -1, 3, 8 }, new int[] { -5, -1, 3, 8 })]
        [TestCase(new int[] { 100, 0, -101, 2 }, new int[] { -101, 0, 2, 100 })]
        [TestCase(new int[] { -10, 0, -4000, -9000, 1 }, new int[] { -9000, -4000, -10, 0, 1 })]
        public void SortAarrayBubbleIncrease_WhenAraaysLoaded_ShoudReternSortArrayIncreaseForBubble(int[] a, int[] expected)
        {
            int[] actual = OneArrays.SortAarrayBubbleIncrease(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void SortAarrayBubbleIncrease_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                OneArrays.SortAarrayBubbleIncrease(array);
            });
        }

        [TestCase(new int[] { 6, 7, 8, 9, 5, 1, 2, 3, 4 }, new int[] { 9,8,7,6,5,4,3,2,1 })]
        [TestCase(new int[] { -5, -1, 3, 8 }, new int[] { 8, 3, -1, -5 })]
        [TestCase(new int[] { 100, 0, -101, 2 }, new int[] { 100, 2, 0, -101 })]
        [TestCase(new int[] { 1, 2 ,3}, new int[] { 3, 2, 1 })]
        public void SortAarraySelectDecrease_WhenAraaysLoaded_ShoudReternSortArrayDecreaseForBubble(int[] a, int[] expected)
        {
            int[] actual = OneArrays.SortAarraySelectDecrease(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(new int[0])]
        public void SortAarraySelectDecrease_WhenAraaysNullorLenghtZero_ShoudReternArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                OneArrays.SortAarraySelectDecrease(array);
            });
        }
    }
}
