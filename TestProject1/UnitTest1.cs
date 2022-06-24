using BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    public class UnitTest1
    {
        public void TestMethod1()
        {
            int[] someArray = new int[] { 9, 4, 8, 7, 5, 6, 2, 1, 3, 0 };
            int[] someArray2 = new int[] { 4, 9, 8, 7, 6, 5, 2, 1, 3, 0 };
            int[] someArray3 = new int[] { 9, 8, 4, 7, 5, 6, 1, 2, 3, 0 };
            int[] someArray4 = new int[] { 0, 4, 8, 5, 7, 6, 2, 1, 3, 9 };
            int[] expectedArray = new int[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };
            MassSort.Bubble_Sort(someArray);
            MassSort.Bubble_Sort(someArray2);
            MassSort.Bubble_Sort(someArray3);
            MassSort.Bubble_Sort(someArray4);
            Assert.AreEqual(someArray, expectedArray);
            Assert.AreEqual(someArray2, expectedArray);
            Assert.AreEqual(someArray3, expectedArray);
            Assert.AreEqual(someArray4, expectedArray);

        }
    }
}
