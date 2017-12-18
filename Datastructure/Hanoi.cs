using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{

    class Hanoi
    {
        public void Tower(int number, string a, string b, string c) 
        {
            if (number == 1)
            {
                Console.WriteLine("{0}-->{1}", a, c);
                return;
            }
            Tower(number - 1, a, c, b);
            Console.WriteLine("{0}-->{1}", a, c);
            Tower(number - 1, b, a, c);
        }

    }

}
