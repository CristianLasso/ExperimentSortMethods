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
        private Random r = new Random();

        void Scenary1() {
            sm = new SortingMethods();
           

            array = new int[10];
            array2 = new int[10];
            array = generate(array);

            array2 = array;

        }

        void Scenary2()
        {
            sm = new SortingMethods();
            array = new int[100];
            array2 = new int[100];
            array = generate(array);

            array2 = array;

        }

        void Scenary3()
        {
            sm = new SortingMethods();
            array = new int[100];
            array2 = new int[100];

            for (int i = 0; i < array.Length;i++) {

                array[i] = i+1;
            }

            array2 = array;

        }

        void Scenary4()
        {
            sm = new SortingMethods();
            array = new int[10];
            array2 = new int[10];

            for (int i = 0; i < array.Length;i++) {

                array[i] = i + 1;
            }

            array2 = array;

        }

        void Scenary5()
        {
            sm = new SortingMethods();
            array = new int[100];
            array2 = new int[100];

            for (int i = 100; i > 0; i--)
            {

                array[i-1] = i;
            }

            array2 = array;

        }

        void Scenary6()
        {
            sm = new SortingMethods();
            array = new int[10];
            array2 = new int[10];

            for (int i = 10; i > 0; i--)
            {

                array[i - 1] = i;
            }

            array2 = array;

        }

        [TestMethod]
        public void SelectionTest1()
        {
            Scenary1();
            sm.QuickSort(array);
            sm.SelectionSort(array2);

            Assert.AreEqual(array[1], array2[1]);
            Assert.IsTrue(array2[1]<array2[2]);
            
        }

        [TestMethod]
        public void SelectionTest2()
        {
            Scenary2();
            sm.BubbleSort(array);
            sm.SelectionSort(array2);

            Assert.AreEqual(array[1], array2[1]);
            Assert.IsTrue(array2[1] < array2[2]);
        }

        [TestMethod]
        public void SelectionTest3()
        {
            Scenary3();
            sm.QuickSort(array);
            sm.SelectionSort(array2);

            Assert.AreEqual(array[1], array2[1]);
            Assert.IsTrue(array2[1] < array2[2]);

        }

        [TestMethod]
        public void SelectionTest4()
        {
            Scenary4();
            sm.BubbleSort(array);
            sm.SelectionSort(array2);

            Assert.AreEqual(array[1], array2[1]);
            Assert.IsFalse(array2[1] > array2[2]);
        }

        [TestMethod]
        public void SelectionTest5()
        {
            Scenary5();
            sm.QuickSort(array);
            sm.SelectionSort(array2);

            Assert.AreEqual(array[1], array2[1]);
            
            Assert.IsFalse(array2[1] > array2[2]);

        }

        [TestMethod]
        public void SelectionTest6()
        {
            Scenary6();
            sm.BubbleSort(array);
            sm.SelectionSort(array2);

            Assert.AreEqual(array[1], array2[1]);
         
            Assert.IsFalse(array2[1] > array2[2]);
        }

        [TestMethod]
        public void GnomeSortTest1()
        {
            Scenary1();
            sm.QuickSort(array);
            sm.GnomeSort(array2, array2.Length);

            Assert.AreEqual(array[1], array2[1]);
        }

        [TestMethod]
        public void GnomeSortTest2()
        {
            Scenary2();
            sm.QuickSort(array);
            sm.GnomeSort(array2, array2.Length);

            Assert.AreEqual(array[1], array2[1]);
        }

        [TestMethod]
        public void GnomeSortTest3()
        {
            Scenary3();
            sm.BubbleSort(array);
            sm.GnomeSort(array2, array2.Length);

            Assert.AreEqual(array[1], array2[1]);
            Assert.IsTrue(array2[1] < array2[2]);

        }

        [TestMethod]
        public void GnomeSortTest4()
        {
            Scenary4();
            sm.BubbleSort(array);
            sm.GnomeSort(array2, array2.Length);

            Assert.AreEqual(array[1], array2[1]);
            Assert.IsFalse(array2[1] > array2[2]);
        }

        [TestMethod]
        public void GnomeSortTest5()
        {
            Scenary5();
            sm.BubbleSort(array);
            sm.GnomeSort(array2, array2.Length);

            Assert.AreEqual(array[1], array2[1]);

            Assert.IsFalse(array2[1] > array2[2]);

        }

        [TestMethod]
        public void GnomeSortTest6()
        {
            Scenary6();
            sm.BubbleSort(array);
            sm.GnomeSort(array2, array2.Length);

            Assert.AreEqual(array[1], array2[1]);

            Assert.IsFalse(array2[1] > array2[2]);
        }

        /**
         * Metodo que genera numeros aleatorios sin repetir
         **/
        public int[] generate(int[] array)
        {
            int num;
            for (int i = 0; i < array.Length; i++)
            {
                do
                {
                    //num = r.Next(1, array.Length);
                    num = r.Next(1, 100);
                } while (alreadyExist(array, num));
                array[i] = num;
            }
            return array;
        }

        /**
         * Función que verifica que un valor no se encuentre dentro del array
         */
        private static bool alreadyExist(int[] array, int r)
        {
            for (int i = 0; i < array.Length; i++)
                if (r == array[i])
                    return true;
            return false;
        }

    }
}
