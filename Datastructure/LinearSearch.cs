using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class LinearArray
    {
        private int[] data;
        private static Random generator = new Random();
        public LinearArray(int size)
        {
            data = new int[size];

            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(10, 100);
            }
            Array.Sort(data);
        }
        public int LinearSearch(int searchElement)
        {
            int value = -1;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == searchElement)
                {
                    value = i;
                    break;
                }
            }
            return value;
        }

        public string RemainingElements()
        {
            string temporary = string.Empty;
            for (int i = 0; i < data.Length; i++)
                temporary += data[i] + " ";

            temporary += "\n";
            return temporary;
        }

        public override string ToString()
        {
            return RemainingElements();
        }
    }
}
