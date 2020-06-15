/*Given a collection of intervals, merge all overlapping intervals.

Example 1:

Input: [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
Example 2:

Input: [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.*/

/*思路：第二个的第二个数 大于 第一个第一个 并且 第二个的第一个 小于等于 第一个的第二个 就说明他们可以合并区间*/

public class Solution {
    int[][] res,result;
    int count;
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length == 0)
                return intervals;
        int count = 1;
        res = new int[intervals.Length][];
        res[0] = intervals[0];        
        for (int i = 1; i < intervals.Length; i++)
        {
            for (int j = 0; j < count; j++)
            {                
                if (intervals[i][0] <= res[j][1] && intervals[i][1] >= res[j][0])
                {
                    res[j] = new int[] { Math.Min(res[j][0], intervals[i][0]),
                                        Math.Max(res[j][1], intervals[i][1]) };
                    intervals[i] = null;
                    break;
                }
            }            
            if (intervals[i] != null)
            {
                res[count++] = intervals[i];
            }
        }
        result = new int[count][];
        //结果标准化--去掉容器的空之部分
        for (int i = 0; i < count; i++)
        {
            result[i] = res[i];
        }

        return result.Length == intervals.Length ? result : Merge(result);
    }
}