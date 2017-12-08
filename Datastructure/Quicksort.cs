using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class Recursive_Quicksort
    {
        public int[] Array { get; private set; }
        public void Run(int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(left, right);
                if (pivot > 1)
                {
                    Run(left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Run(pivot + 1, right);
                }
            }
        }
        int Partition(int left, int right)
        {
            int pivot = Array[left];
            while (true)
            {
                while (Array[left] < pivot)
                {
                    left++;
                }
                while (Array[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (Array[left] == Array[right])
                        return right;
                    int temp = Array[left];
                    Array[left] = Array[right];
                    Array[right] = temp;
                }
                else
                {
                    return right;
                }
            
            }
        }
        public Recursive_Quicksort(int[] arr)
        {
            Array = arr;
        }
    }
}
