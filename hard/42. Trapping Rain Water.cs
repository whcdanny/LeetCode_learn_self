/*
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.


The above elevation map is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped. Thanks Marcos for contributing this image!

Example:

Input: [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
*/
/*思路：记录左边和右边的当前高度，然后计算。*/

public class Solution {
    public int Trap(int[] height) {
        int leftHeight = 0;
        int rightHeight = 0;
        int left = 0;
        int right = height.Length - 1;
        int result = 0;
        while(left < right){
            if(height[left] <= height[right]){
                int leftResult = leftHeight - height[left] >= 0 ? leftHeight - height[left] : 0;
                leftHeight = Math.Max(leftHeight, height[left]);
                result += leftResult;
                left++;
            }else{
                int rightResult = rightHeight - height[right] >= 0 ? rightHeight - height[right] : 0;
                rightHeight = Math.Max(rightHeight, height[right]);
                result += rightResult;
                right--;
            }
        }
        
        return result;
    }
}