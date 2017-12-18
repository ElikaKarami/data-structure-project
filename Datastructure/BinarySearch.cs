using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class BinaryArray
    {
        private int[] data;
        private static Random generator = new Random();
        public BinaryArray(int size)
        {
            data = new int[size];

            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(10, 100);
            }
            Array.Sort(data);
        }
        public int BinarySearch(int searchElement)
        {
            int low = 0;
            int high = data.Length - 1;
            int middle = (low + high + 1) / 2;
            int location = -1;

            do
            {
                Console.Write(RemainingElements(low, high));

                for (int i = 0; i < middle; i++)
                    Console.Write("   ");

                Console.WriteLine(" * ");
                if (searchElement == data[middle])
                    location = middle;
                else if (searchElement < data[middle])
                    high = middle - 1;
                else
                    low = middle + 1;

                middle = (low + high + 1) / 2;
            } while ((low <= high) && (location == -1));

            return location;
        }
        public string RemainingElements(int low, int high)
        {
            string temporary = string.Empty;
            for (int i = 0; i < low; i++)
                temporary += "    ";
            for (int i = low; i <= high; i++)
                temporary += data[i] + " ";
            temporary += "\n";
            return temporary;
        }
        public override string ToString()
        {
            return RemainingElements(0, data.Length - 1);
        }
    }
}