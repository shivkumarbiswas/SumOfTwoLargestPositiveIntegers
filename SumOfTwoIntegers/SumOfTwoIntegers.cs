using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoIntegers
{
    public class SumOfTwoIntegers
    {
        public int AddTwoLargestIntegers(int[] sequence)
        {
            int max = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] > max)
                {
                    secondMax = max;
                    max = sequence[i];
                }
                else if(sequence[i] > secondMax && sequence[i] < max)
                {
                    secondMax = sequence[i];
                }
            }

            return Math.Abs(max + (secondMax != int.MinValue ? secondMax : 0));
        }
    }
}
