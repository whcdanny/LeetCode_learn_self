/*Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.

Example 1:

Input: 2
Output: [0,1,1]
Example 2:

Input: 5
Output: [0,1,1,2,1,2]*/
/*思路：要知道二进制 然后算出从0到这个数在二进制中一个总和*/

public class Solution {
    public int[] CountBits(int num) {
        int[] result=new int[num+1];
        result[0]=0;
        for(int i=1;i<result.Length;i++){
            if(i%2==0) result[i]=result[i/2];
            else result[i]=result[i-1]+1;
        }
        return result;
    }
}