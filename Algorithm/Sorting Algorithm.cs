using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Sorting_Algorithm
    {
        // Bubble Sort
        public static void BubbleSort(int[] a )
        {
            for(int i = a.Length - 1; i > 0; i--)
            {
                // Couting dawn
                for(int j = 0; j < i; j++)
                {
                    //bubbling up
                    if (a[j] > a[j + 1])
                    {
                        //Then Swap
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        // Selection Sort
        public static void SelectionSort(int[] a)
        {
            for(int i = 0; i < a.Length- 1; i++)
            {
                int min = a[i]; // Min = First value of array
                for(int j=i+1; j < a.Length; j++)
                {
                    if (min > a[j])
                    {
                        // Swapping
                        int temp = min;
                        min = a[j];
                        a[j] = temp;
                        a[i] = min;
                    }
                }
            }
        }
        // Insertion Sort
        public static void InsertionSort(int[] a)
        {
            for(int i = 1; i < a.Length - 1; i++)
            {
                int temp=a[i];
                int location = i - 1;
                while (location >= 0 && a[location]>temp)
                {
                    a[location + 1] = a[location];
                    location = location - 1;
                }
                a[location +1] = temp;
            }  
        }
        //Quick sort
        public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    /*Swap(arr, i, j);*/
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            Swap(arr, i + 1, right);

            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        
        //Heap Sort
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;


            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                // Recursively heapify the affected sub-tree
                Heapify(arr, n, largest);
            }
        }

    }
}
