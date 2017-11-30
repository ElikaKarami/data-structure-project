using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class LinearSearch
    {
        public int[] Array { get; private set; }
        public int linearSearch(int item)
        {
            int value = -1;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == item)
                {
                    value = i;
                    break;
                }
            }
            return value;
        }
        public LinearSearch(int[] arr)
        {
            Array = arr;
        }
    }
}
