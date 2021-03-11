using NUnit.Framework;

namespace TaskMatvii.Tests
{
    public class SecondArraysTests
    {
        //[TestCase(new int[,]
        //{
        //    { 1, 2, 3, 4, 5 },
        //    { -10, 0, -40, -90,2},
        //    { 32, 12, -10, 100,2}
        //},)]
        
        public void OutputMinElementsSecondArrays_WhenAraaysLoaded_ShoudReternMinElements(int[,] a, int expected)
        {
            int actual = SecondArray.OutputMinElementsSecondArrays(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
