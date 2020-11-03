public class Solution {
    public int[][] GenerateMatrix(int n) {
        var result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }

            var left = 0;
            var top = 0;
            var right = n;
            var bottom = n;

            var number = 1;

            while (left < right && top < bottom)
            {
                for (var i = left; i < right; i++)
                {
                    result[top][i] = number++;
                }

                for (var i = top + 1; i < bottom; i++)
                {
                    result[i][right - 1] = number++;
                }

                if (top < bottom - 1 && left < right - 1)
                {
                    for (var i = right - 2; i >= left; i--)
                    {
                        result[bottom - 1][i] = number++;
                    }

                    for (var i = bottom - 2; i > top; i--)
                    {
                        result[i][left] = number++;
                    }
                }

                left++;
                top++;
                right--;
                bottom--;
            }

            return result;
    }
}