using BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    public class UnitTest1
    {
        public void TestMethod1()
        {
            int[] someArray = new int[] { 9, 4, 8, 7, 5, 6, 2, 1, 3, 0 };
            int[] expectedArray = new int[] { 1, 2, 4, 3, 8, 5, 7, 6, 9, 0 };
            MassSort.Bubble_Sort(someArray);
            int k = 0;
            int j;
            for (j = 0; j < someArray.Length ; j++)
            {
                //Если элемент массива с индексом j больше следующего за ним элемента
                if (someArray[j] == expectedArray[j])
                {
                    k++;
                }
            }
            Assert.AreEqual(k, j);
        }
    }
}
