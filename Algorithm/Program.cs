using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 8, 3, 9, 11 };
            // Bubble Sort          
            Console.WriteLine("Un-Sorted array :\n");            
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n==============================================================\n");
            
            Sorting_Algorithm.BubbleSort(arr); // Bec Method Is Static
            Console.WriteLine("Sorted array Using Bubble-Sort:\n");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n==============================================================\n" );
            

            // Selection Sort
            Sorting_Algorithm.SelectionSort(arr);
            Console.WriteLine("Sorted array Using Selection-Sort:\n");
            foreach (int num in arr)
                {
                  Console.Write(num + " ");
                }
            Console.WriteLine("\n==============================================================\n");
            

            // Insertion Sort                        
            Sorting_Algorithm.InsertionSort(arr);
            Console.WriteLine("Sorted array Using Insertion-Sort:\n");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n==============================================================\n");
            

            // Quick Sort           
            Sorting_Algorithm.QuickSort(arr);
            Console.WriteLine("Sorted array Using Quick-Sort:\n");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n==============================================================\n");
            

            // Heap Sort            
            Sorting_Algorithm.QuickSort(arr);
            Console.WriteLine("Sorted array Using Heap-Sort:\n");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n==============================================================\n");
            Console.WriteLine();

        }
    }
}
