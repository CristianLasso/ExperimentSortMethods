using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Experiment;

namespace SortMethodsTest
{
    [TestClass]
    public class SortingTest
    {
        private int[] array;
        private int[] array2;
        private SortingMethods sm;

        void Scenary1() {
            sm = new SortingMethods();
            array = new int[6];
            array2 = new int[6];

            for (int i=0;i<array.Length;i++) {
                array[i] = i + 7 * i;
                array2[i] = i + 7 * i;
            }

        }

        [TestMethod]
        public void InsertionTest1()
        {
            Scenary1();
            sm.QuickSort(array);
            sm.SelectionSort(array2);

            Assert.AreEqual(array[1],array2[1]);
        }

        [TestMethod]
        public void QuickSortTest1()
        {
            Scenary1();
            sm.QuickSort(array);
            sm.SelectionSort(array2);

            Assert.AreEqual(array[1], array2[1]);
        }


    }
}
