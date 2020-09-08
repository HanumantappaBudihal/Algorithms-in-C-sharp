using System;
using System.Collections.Generic;
using System.Text;

namespace Hexagonal.Algorithms.Other
{
    // Study References : 
    //   from             auxilary         to
    //    A=1                B=2           C=3
    //    TowerOfHanio( n-1, 1, 3 ,2)
    //    Move (1,3)
    //    TowerOfHanio (n-1, 2, 1 ,3)
    //  Approach : 
    //  Shift (n-1) disks from A to B using C ( 132)
    //  Shift last disk from A to C
    //  Shitt (n-1) disks from B to C using A ( 213)
    //Min move required : (2^n-1)
    public class TowerOfHanoi
    {
        public static void PrintMoves(int numberOfDisks, string from, string auxiliary, string to)
        {
            if (numberOfDisks > 0)
            {
                PrintMoves(numberOfDisks - 1, from, to, auxiliary); //move (n-1) disk from A to B using C as auxiliary
                Console.WriteLine("Move disk from " + from + " to " + to);//move last disk from A to C
                PrintMoves(numberOfDisks - 1, auxiliary, from, to);// move n-1 from B to C using A as auxiliary 
            }
        }
    }
}
