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
            array = new int[6];
            array2 = new int[6];

            //array = new int[1000];
            //array = generarNumerosNoRepetidos(array);

            for (int i=0;i<array.Length;i++) {
                array[i] = i + 7 * i;
                array2[i] = i + 7 * i;
            }

        }

        void Scenary2()
        {
            sm = new SortingMethods();
            int[] arr = { 12, 11, 13, 5, 6, 7, 2, 1, 8, 25 };
            array2 = new int[arr.Length];
            array = new int[arr.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = arr[i] ;
                array2[i] = arr[i];
            }

        }

        [TestMethod]
        public void SelectionTest1()
        {
            Scenary1();
            sm.QuickSort(array);
            sm.SelectionSort(array2);

            Assert.AreEqual(array[1],array2[1]);
        }

        [TestMethod]
        public void SelectionTest2()
        {
            Scenary2();
            sm.BubbleSort(array);
            sm.SelectionSort(array2);

            Assert.AreEqual(array[1], array2[1]);
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
