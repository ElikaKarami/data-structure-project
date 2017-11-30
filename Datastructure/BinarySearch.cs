using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class BinarySearch
    {
        public int[] Array { get; private set; }
        public int Run(int value)
        {
            int low = 0;
            int high = Array.Length - 1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (value == Array[middle])
                {
                    return middle;
                }
                else if (value < Array[middle])
                    high = middle - 1;
                else
                    low = middle + 1;
            }
            return -1;
        }
        public BinarySearch(int[] arr)
        {
            Array = arr;
        }
    }    
   
}
