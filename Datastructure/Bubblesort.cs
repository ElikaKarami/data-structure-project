using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    public class BubbleSort
    {
       public int[] Array { get;private set; }

    public void Run()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Array[j] > Array[i])
                    {
                        BubbleSort.Swap(ref Array[j], ref Array[i]);
                    }
                }
            }
            
        }
        public BubbleSort(int[] arr)
        {
            Array = arr;
        }
        public static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
