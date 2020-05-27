/*Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

Example 1:

Input: 121
Output: true
Example 2:

Input: -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.*/

/*思路：利用c#里反转 一比较就知道了*/

public class Solution {
    public bool IsPalindrome(int x) {
        var arr = x.ToString().ToCharArray();
        Array.Reverse(arr);
        return x.ToString() == new string(arr);
    }
}