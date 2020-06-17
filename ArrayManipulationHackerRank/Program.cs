using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulationHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //input based on the hacker rank input
            int[][] arrManipulation = new int[][]
            {
                new int[] {1, 2, 100 },
                new int[] { 2, 5, 100},
                    new int[] { 3, 4, 100}

            };

            ArrayManipulation arm = new ArrayManipulation();
            long value = arm.ProcessArrayManipulation(5, arrManipulation);
            Console.WriteLine($"Max value:{value}");
            Console.ReadKey();
        }
    }
}
