/*
给定整数数组 A，每次 move 操作将会选择任意 A[i]，并将其递增 1。
返回使 A 中的每个值都是唯一的最少操作次数。
示例 1:
输入：[1,2,2]
输出：1
解释：经过一次 move 操作，数组将变为 [1, 2, 3]。
示例 2:
输入：[3,2,1,2,1,7]
输出：6
解释：经过 6 次 move 操作，数组将变为 [3, 4, 1, 2, 5, 7]。
可以看出 5 次或 5 次以下的 move 操作是不能让数组的每个值唯一的。
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[5];
            test[0] = 3;
            test[1] = 2;
            test[2] = 1;
            test[3] = 2;
            test[4] = 6;
            Console.WriteLine(MinIncrementForUnique(test));
        }
        public static int MinIncrementForUnique(int[] A)
        {
            int result = 0;            
            List<int> list = new List<int>(A);
            for (int i = 0; i < list.Count; i++)
            {
                int num = list[i];
                if (!numIsUnique(i, list))
                {
                    list.Remove(i);
                    list.Add(num + 1);
                    result++;
                    i--;
                }
            }
            return result;
        }
        public static bool numIsUnique(int _num, List<int> _A)
        {
            int count = 0;
            for (int i = 0; i < _A.Count; i++)
            {
                if (_A[i] == _num)
                    count++;
            }
            if (count > 1)
                return false;
            else
                return true;
        }
    }
}

/*public class Solution {
    public int MinIncrementForUnique(int[] A) {
        const int Step1 = 40000;
        ushort[] count = new ushort[Step1];
        foreach (int a in A) count[a]++;

        int ret = 0;
        int takenCount = 0;
        int index = 0;
        for (; index < Step1; ++index)
        {
            var c = count[index];
            if ( 1 < c )
            {
                int taken = c - 1;
                takenCount += taken;
                ret -= index * taken;
            }
            else if ( 0 < takenCount && c == 0)
            {
                takenCount--;
                ret += index;
            }
        }

        //for (; 0 < takenCount; ++index)
        //{
        //    takenCount--;
        //    ret += index;
        //}


        //if( 0 < takenCount ) ret += (index + index + takenCount - 1) * takenCount / 2;

        if (0 < takenCount)
        {
            ret += index * takenCount;
            ret += (takenCount - 1) * takenCount / 2;
        }

        return ret;
    }    
}*/