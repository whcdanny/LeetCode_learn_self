public class Solution {
    public int LargestRectangleArea(int[] heights) {
         int maxarea = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            int minheight = Int32.MaxValue;
            for (int j = i; j < heights.Length; j++)
            {
                minheight = Math.Min(minheight, heights[j]);
                maxarea = Math.Max(maxarea, minheight * (j - i + 1));
            }
        }
        return maxarea;
    }
}