using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Datastructure
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Welcome to this menu");
            Console.WriteLine("Please choose an action:");
            Console.WriteLine("1.Quick Sort");
            Console.WriteLine("2.Binary Search");
            Console.WriteLine("3.Bubble Sort");
            Console.WriteLine("4.Linear Search");
            Console.WriteLine("5.Hanoi");
        }
        public static void FillArray(ref int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,arr.Length*2);
            }
        }
        public static void Wait()
        {
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static void PreviewArray(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

        }
        static void QuickSort()
        {
            Console.WriteLine("enter array size");
            int size = Prompt();
            int[] values = new int[size];
            Stopwatch stopwatch = new Stopwatch();
            FillArray(ref values);
            Recursive_Quicksort qs = new Recursive_Quicksort(values);
            PreviewArray(qs.Array);
            Wait();
            stopwatch.Start();
            //Console.WriteLine("enter value to search");
            //int value = Prompt();
            //var result = qs.Run(value);
            qs.Run(0,values.Length-1);
            stopwatch.Stop();
            Console.WriteLine("Array is now sorted:");
            //if (result != -1)
            //    Console.WriteLine($"Element is found at index {result.ToString()}");
            //else
            //    Console.WriteLine($"Element not found!");

            PreviewArray(qs.Array);
            Console.WriteLine($"Time taken:{stopwatch.Elapsed.TotalMilliseconds}ms");
        }
        static void BinarySearch()
        {
            int searchInt; // seach key
            int position; // location of search key in array

            // create array and output it
            BinaryArray searchArray = new BinaryArray(15);
            Console.WriteLine(searchArray);

            // prompt and input first int from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // repeatedly input an integer; -1 terminates the application
            while (searchInt != -1)
            {
                // use binary search to try to find integer
                position = searchArray.BinarySearch(searchInt);

                // return value of -1 indicates integer was not found
                if (position == -1)
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);
                else
                    Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);

                // Prompt and input next int from user 
                Console.WriteLine("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            }

            //    Console.WriteLine("enter array size");
            //    int size = Prompt();
            //    Stopwatch stopwatch = new Stopwatch();
            //    int[] values = new int[size];
            //    FillArray(ref values);
            //    BinarySearch bs = new BinarySearch(values);
            //    BubbleSort Elika = new BubbleSort(values);
            //    PreviewArray(Elika.Array);
            //    Wait();
            //    stopwatch.Start();
            //    Console.WriteLine("enter value to search");
            //    int value = Prompt();
            //    var result = bs.Run(value);
            //    stopwatch.Stop();
            //    Console.WriteLine("Array is now sorted:");
            //    if (result != -1)
            //        Console.WriteLine($"Element is found at index {result.ToString()}");
            //    else
            //        Console.WriteLine($"Element not found!");

            //    PreviewArray(bs.Array);
            //    Console.WriteLine($"Time taken:{stopwatch.Elapsed.TotalMilliseconds}ms");

        }
        static void BubbleSort()
        {
            Console.WriteLine("enter array size");
            int size = Prompt();
            int[] values = new int[size];
            Stopwatch stopwatch = new Stopwatch();
            FillArray(ref values);
            BubbleSort BS = new BubbleSort(values);
            PreviewArray(BS.Array);
            Wait();
            stopwatch.Start();
            //Console.WriteLine("enter value to search");
            //int value = Prompt();
            //var result = qs.Run(value);
            BS.Run();
            stopwatch.Stop();
            Console.WriteLine("Array is now sorted:");
            //if (result != -1)
            //    Console.WriteLine($"Element is found at index {result.ToString()}");
            //else
            //    Console.WriteLine($"Element not found!");

            PreviewArray(BS.Array);
            Console.WriteLine($"Time taken:{stopwatch.Elapsed.TotalMilliseconds}ms");
        }
        static void LinearSearch()
        {
            int searchInt; // seach key
            int position; // location of search key in array

            // create array and output it
            LinearArray searchArray = new LinearArray(15);
            Console.WriteLine(searchArray);

            // prompt and input first int from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // repeatedly input an integer; -1 terminates the application
            while (searchInt != -1)
            {
                // use binary search to try to find integer
                position = searchArray.LinearSearch(searchInt);

                // return value of -1 indicates integer was not found
                if (position == -1)
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);
                else
                    Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);

                // Prompt and input next int from user 
                Console.WriteLine("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            }
            //    Console.WriteLine("enter array size");
            //    int size = Prompt();
            //    Stopwatch stopwatch = new Stopwatch();
            //    int[] values = new int[size];
            //    FillArray(ref values);
            //    BinarySearch ls = new BinarySearch(values);
            //    PreviewArray(ls.Array);
            //    Wait();
            //    stopwatch.Start();
            //    Console.WriteLine("enter value to search");
            //    int value = Prompt();
            //    var result = ls.Run(value);
            //    stopwatch.Stop();
            //    if (result != -1)
            //        Console.WriteLine($"Element is found at index {result.ToString()}");
            //    else
            //        Console.WriteLine($"Element not found!");
            //    Console.WriteLine($"Time taken:{stopwatch.Elapsed.TotalMilliseconds}ms");
            //}
            //static void Hanoi()
            //{
            //    Console.WriteLine("enter array size");
            //    int size = Prompt();
            //    Stopwatch stopwatch = new Stopwatch();
            //    int[] values = new int[size];
            //    FillArray(ref values);
            //    BinarySearch Hanoi = new BinarySearch(values);
            //    PreviewArray(Hanoi.Array);
            //    Wait();
            //    stopwatch.Start();
            //    Console.WriteLine("enter value to search");
            //    int value = Prompt();
            //    var result = Hanoi.Run(value);
            //    stopwatch.Stop();
            //    if (result != -1)
            //        Console.WriteLine($"Element is found at index {result.ToString()}");
            //    else
            //        Console.WriteLine($"Element not found!");
            //    Console.WriteLine($"Time taken:{stopwatch.Elapsed.TotalMilliseconds}ms");
        }
        public static int Prompt()
        {
            int input = 0;
            while (!int.TryParse(Console.ReadLine(),out input))
            {
                Console.WriteLine("wrong!enter correct input");
                //Console.Clear();
            }

            return input;
        }
        static void Main(string[] args)
        {

            while (true)
            {
                Menu();
                //Prompt();
                switch (Prompt())
                {
                    case 1:
                        QuickSort();
                        break;

                    case 2:
                        BinarySearch();
                        break;
                    case 3:
                        BubbleSort();
                        break;
                    case 4:
                        LinearSearch();
                        break;
                    case 5:
                        //hanoi();
                        break;



                }
            }
        }
    }
}
