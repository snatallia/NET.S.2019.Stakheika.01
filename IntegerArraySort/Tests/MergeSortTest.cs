using System;
using IntegerArraySort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MergeSortTest
    {   
        [TestMethod]
        public void TestMergeSort()
        {
            int[] array1 = new[] { 10, -1, 2 };
            int[] array2 = new[] { -1, 2, 10 };
            SortArray.MergeSort(array1, 0, 2);
            CollectionAssert.AreEqual(array1, array2);

        }

        [TestMethod]
        public void TestMergeSortWithNullArray()
        {
            Assert.ThrowsException<ArgumentNullException>(()=>SortArray.MergeSort(null,0,0));            
        }

        

    }
}
