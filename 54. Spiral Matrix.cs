/*Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.

Example 1:

Input:
[
 [ 1, 2, 3 ],
 [ 4, 5, 6 ],
 [ 7, 8, 9 ]
]
Output: [1,2,3,6,9,8,7,4,5]
Example 2:

Input:
[
  [1, 2, 3, 4],
  [5, 6, 7, 8],
  [9,10,11,12]
]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]*/

/*思路：分四个方向 然后确定上下左右的界限*/

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> spiralOrder = new List<int>();

        int m = matrix.GetLength(0);
        if(m==0)
            return spiralOrder;
        int n = matrix[0].GetLength(0);

        int direction = 0;

        int top = 0;
        int left = 0;
        int bottom = m - 1;
        int right = n - 1;

        while (bottom >= top && right >= left)
        {
            if (direction == 0)
            { // moving left to right, on top
                for (int i = left; i <= right; i++)
                {
                    spiralOrder.Add(matrix[top][i]);
                }
                top += 1;
            }
            else if (direction == 1)
            { // moving top to bottom, on right
                for (int i = top; i <= bottom; i++)
                {
                    spiralOrder.Add(matrix[i][right]);
                }
                right -= 1;
            }
            else if (direction == 2)
            { // moving right to left, on bottom
                for (int i = right; i >= left; i--)
                {
                    spiralOrder.Add(matrix[bottom][i]);
                }
                bottom -= 1;
            }
            else if (direction == 3)
            { // moving bottom to top, on left
                for (int i = bottom; i >= top; i--)
                {
                    spiralOrder.Add(matrix[i][left]);
                }
                left += 1;
            }
            direction = (direction + 1) % 4;
        }
        return spiralOrder;
    }
}