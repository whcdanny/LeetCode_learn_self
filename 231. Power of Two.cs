public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n == 0 || n < 0) 
            return false;
                
        while(n > 1) {            
            if((n & 1) != 0) 
                return false;
            n >>= 1;
        }        
        return true;
    }
}

//Java
class Solution {
    public boolean isPowerOfTwo(int n) {
        if(n == 0 || n < 0) 
            return false;
                
        while(n > 1) {            
            if((n & 1) != 0) 
                return false;
            n >>= 1;
        }        
        return true;
    }
}