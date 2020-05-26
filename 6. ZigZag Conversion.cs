/*The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string s, int numRows);
Example 1:

Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
Example 2:

Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:

P     I    N
A   L S  I G
Y A   H R
P     I*/
/*思路：两个数列之中的距离是 (numRows-2)， 然后从头开始 跳过这个距离 然后找第一个这个距离的， 
因为只有第一行和最后一行间距是 (numRows-2); 所以要找到第一个不是往后 而是往前找*/

public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows == 1 || s.Length <= numRows)
            return s;
        
        char[] retArr = new char[s.Length];
        int index = 0;
        int cycleLen = 2 * numRows - 2;//numRows+(numRows-2);
        for(int i =0;i< numRows; i++)
        {    
            for(int j =0; j + i < s.Length; j+= cycleLen)
            {
                retArr[index++] = s[j + i];
                if(i != 0 && i != numRows-1 && j + cycleLen - i < s.Length)
                    retArr[index++] = s[j + cycleLen -i];
            }
        }
           
        return new string(retArr);
    }
}