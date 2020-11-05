public class Solution {
    public int[] PlusOne(int[] digits) {
        int add = 1;
        for(int i = digits.Length-1; i>=0; --i){
            int num = digits[i]+add;
            digits[i]=num%10;
            add = num/10;
        }
        if(add==1){
            int[] newDigits = new int[digits.Length+1];
            newDigits[0]=1;
            int s = 0;
            foreach(int i in digits){
                newDigits[s+1]=digits[s];
                ++s;
            }
            return newDigits;
        }      
        else{
            return digits;   
        }                
    }
}
