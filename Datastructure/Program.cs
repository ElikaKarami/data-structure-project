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
            Console.WriteLine("******************************************Welcome To This Menu******************************************");
            Console.WriteLine("Please choose an action:");
            Console.WriteLine("\t \t 1.Quick Sort");
            Console.WriteLine("\t \t 2.Bubble Sort");
            Console.WriteLine("\t \t 3.Binary Search");
            Console.WriteLine("\t \t 4.Linear Search");
            Console.WriteLine("\t \t 5.Hanoi");
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
            qs.Run(0, values.Length - 1);
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Array is now sorted:");
            PreviewArray(qs.Array);
            Console.WriteLine($"Time taken:{stopwatch.Elapsed.TotalMilliseconds}ms");
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
            BS.Run();
            stopwatch.Stop();
            Console.Clear();
            Console.WriteLine("Array is now sorted:");
            PreviewArray(BS.Array);
            Console.WriteLine($"Time taken:{stopwatch.Elapsed.TotalMilliseconds}ms");
        }
        static void BinarySearch()
        {
            int searchInt;
            int position;
            Stopwatch stopwatch = new Stopwatch();
            BinaryArray searchArray = new BinaryArray(15);
            stopwatch.Start();
            Console.WriteLine(searchArray);
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            stopwatch.Stop();
            Console.WriteLine();

            while (searchInt != -1)
            {
                position = searchArray.BinarySearch(searchInt);
                if (position == -1)
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);
                else
                    Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);
                Console.WriteLine($"Time taken:{stopwatch.Elapsed.TotalMilliseconds}ms");
                Console.WriteLine("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
            }
        }
        static void LinearSearch()
        {
            int searchInt;
            int position;

            LinearArray searchArray = new LinearArray(15);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(searchArray);
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            stopwatch.Stop();
            Console.WriteLine();
            while (searchInt != -1)
            {
                position = searchArray.LinearSearch(searchInt);

                if (position == -1)
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);
                else
                    Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);
                Console.WriteLine($"Time taken:{stopwatch.Elapsed.TotalMilliseconds}ms");
                Console.WriteLine("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();

            }
        }

        static public void Hanoi()
        {
            Console.WriteLine("enter array size");
            string input = Console.ReadLine();
            int number;
            Int32.TryParse(input, out number);
            Stopwatch stopwatch = new Stopwatch();
            Hanoi hanoi = new Hanoi();
            //Wait();
            stopwatch.Start();
            hanoi.Tower(number,"A","B","C");
            stopwatch.Stop();
            //Console.Clear();
            Console.WriteLine($"Time taken:{stopwatch.Elapsed.TotalMilliseconds}ms");
        }

        public static int Prompt()
        {
            int input = 0;
            while (!int.TryParse(Console.ReadLine(),out input))
            {
                Console.WriteLine("wrong!enter correct input");
            }
            return input;
        }
        static void Main(string[] args)
        {

            while (true)
            {
                Menu();
                switch (Prompt())
                {
                    case 1:
                        QuickSort();
                        break;
                    case 2:
                        BubbleSort();
                        break;
                    case 3:
                        BinarySearch();
                        break;
                    case 4:
                        LinearSearch();
                        break;
                    case 5:
                        Hanoi();
                        break;
                }
            }
        }
    }
}
