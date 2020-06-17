using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulationHackerRank
{
    public class ArrayManipulation
    {
        public long GetMaximuSumValue(long[] resultingArr)
        {
            long maximumSumValue = int.MinValue;
            long sum = 0;
            for (int i = 0; i < resultingArr.Length; i++)
            {
                sum += resultingArr[i];
                maximumSumValue = Math.Max(maximumSumValue, sum);

            }
            return maximumSumValue;
        }
        public long ProcessArrayManipulation(int n, int[][] arr)
        {
            int a, b, k = 0;
           
            long[] resultingArr = new long[n + 2];
            for (int i = 0; i < arr.Length; i++)
            {
                a = arr[i][0];
                b = arr[i][1];
                k = arr[i][2];
                resultingArr[a] = resultingArr[a] + k;
                resultingArr[b + 1] = resultingArr[b + 1] - k;

             

            }
           

            return GetMaximuSumValue(resultingArr);
        }
    }
}
