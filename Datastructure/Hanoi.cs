using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    class Hanoi
    {
        public static void TowerofHanoi(int diskCount, int fromPole, int toPole, int viaPole)
        {
            if (diskCount == 1)
            {
                System.Console.WriteLine("Move disk from pole " + fromPole + " to pole " + toPole);
            }
            else
            {
                TowerofHanoi(diskCount - 1, fromPole, viaPole, toPole);
                TowerofHanoi(1, fromPole, toPole, viaPole);
                TowerofHanoi(diskCount - 1, viaPole, toPole, fromPole);
            }
        }
    }
}
