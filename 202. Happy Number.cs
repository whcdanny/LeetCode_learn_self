public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> set = new HashSet<int>();
        while (n != 1)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += (n % 10)*(n % 10);
                n = n / 10;
            }
            if (set.Contains(sum)){
                return false;
            }
            else{
                set.Add(sum);
            }
            n = sum;
        }
        return true;
    }
}

//Java
class Solution {
    public boolean isHappy(int n) {
        Set<Integer> set = new HashSet<Integer>();
        while(n!=1){
            int sum=0;
            while(n>0){
                sum+=(n%10)*(n%10);
                n=n/10;
            }
            if(set.contains(sum)){
                return false;
            }
            else{
                set.add(sum);
            }
            n=sum;
        }
        return true;
    }
}