using NUnit.Framework;
using System.Collections.Generic;
using IntegerArraySort;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        #region GetQuickSort
        private static IEnumerable<TestCaseData> DataCasesForQuickSortTest
        {   
            get
            {
                yield return new TestCaseData(
                    new[] { -1, 10, 3},
                    new[] { -1, 3,10 },
                    "Array was sorted wrong");
                yield return new TestCaseData(
                    new[] { -2, -10, 3, 40, 5, 7, 11 },
                    new[] { -10, -2,3,5,7, 11,40 },
                    "Array was sorted wrong");
                yield return new TestCaseData(
                    new[] { -1, 10, 3 },
                    new[] { -1, 3, 10 },
                    "Array was sorted wrong");
                yield return new TestCaseData(
                    new[] { 0 },
                    new[] { 0 },
                    "Array was sorted wrong");
            }
        }

        [TestCaseSource(nameof(DataCasesForQuickSortTest))]
        public void GetQuickSortTests(int[] data, int[] expected, string message)
        {
            SortArray.QuickSort(data, 0, data.Length - 1);
            CollectionAssert.AreEqual(data, expected, message: message);
        }

        #endregion

        [Test]
        public void TestMergeSortWithNullArray()
        {
            Assert.Throws(typeof(ArgumentNullException),()=> SortArray.MergeSort(null, 0, 0));            
        }
    }
}