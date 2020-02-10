using System;

namespace Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            int n = arr.Length;

            SortingMethods sm = new SortingMethods();
            //sm.BubbleSort(arr);
            //sm.SelectionSort(arr);
            //sm.QuickSort(arr, 0, arr.Length-1);
            //sm.MergeSort(arr, 0, arr.Length-1);
            //sm.HeapSort(arr);
            //sm.GnomeSort(arr, arr.Length);



            Console.WriteLine("Sorted array is");
            printArray(arr);
        }

        /* A utility function to print array of size n */
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.Read();
        }
    }
}
