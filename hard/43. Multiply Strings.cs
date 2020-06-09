/*
Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.

Example 1:

Input: num1 = "2", num2 = "3"
Output: "6"
Example 2:

Input: num1 = "123", num2 = "456"
Output: "56088"
*/

/*思路：从后往前一位一位乘，然后再根据商和余来进位*/

public class Solution {
    public string Multiply(string num1, string num2) {
        if (num1 == "0" || num2 == "0") return "0";
        string res = "";
        int[] buffer = new int[num1.Length + num2.Length];
        int compare = num1.Length + num2.Length - 2;
        int carry = 0;
        for(int i = 0;i<num1.Length;i++)
        {
            for(int j = 0;j<num2.Length;j++)
            {
                buffer[compare - i - j] += (num1[i] - '0') * (num2[j] - '0');
            }
        }
        for(int i = 0;i<buffer.Length;i++)
        {
            buffer[i] += carry;
            carry = buffer[i] / 10;
            buffer[i] %= 10;
        }
        int t = buffer.Length - 1;
        while (buffer[t] == 0) t--;
        if (t < 0) return "0";
        while(t>=0)
        {
            res += ((char)(buffer[t] + '0')).ToString();
            t--;
        }
        return res;   
    }
}