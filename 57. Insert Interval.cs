/*Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).

You may assume that the intervals were initially sorted according to their start times.

Example 1:

Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]
Example 2:

Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].*/

/*思路：先判断是否在这个区间，然后在判断在区间的前面的值还是后面的值*/


public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        if (intervals.Length == 0) 
			return newInterval.Length == 0 ? new int[0][] : new []{ newInterval };
        if (newInterval.Length == 0) 
			return intervals;
        List<int[]> result = new List<int[]>(intervals.Length + 1);
        bool addedNewInterval = false;

        foreach (int[] interval in intervals)
        {
            bool isBeforeNewInterval = interval[1] < newInterval[0];
            bool isAfterNewInterval = interval[0] > newInterval[1];
            
			if (isAfterNewInterval && !addedNewInterval)
            {
                result.Add(newInterval);
                addedNewInterval = true;
            }
            if (isBeforeNewInterval || isAfterNewInterval)
                result.Add(interval);

            bool intersectsNewAtBeginning = newInterval[0] >= interval[0] && newInterval[0] <= interval[1];
            bool intersectsNewAtEnd = newInterval[1] >= interval[0] && newInterval[1] <= interval[1];

            if (intersectsNewAtBeginning)
                newInterval[0] = interval[0];

            if (intersectsNewAtEnd)
                newInterval[1] = interval[1];
        }

        if (!addedNewInterval && newInterval.Length > 0)
            result.Add(newInterval);

        return result.ToArray();
    }
}