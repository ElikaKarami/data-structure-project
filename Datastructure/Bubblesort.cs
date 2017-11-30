using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    public class BubbleSort
    {
       public int[] Numbers { get;private set; }

    public void Run()
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Numbers[j] > Numbers[i])
                    {
                        BubbleSort.Swap(ref Numbers[j], ref Numbers[i]);
                    }
                }
            }
            
        }
        public BubbleSort(int[] arr)
        {
            Numbers = arr;
        }
        public static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
