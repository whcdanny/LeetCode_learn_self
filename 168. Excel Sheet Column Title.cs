public class Solution {
    public string ConvertToTitle(int n) {
        StringBuilder sb = new StringBuilder();
        while (n != 0)
        {
            n--;
            sb.Insert(0, (char)('A' + n % 26));
            n /= 26;
        }
        return sb.ToString();
    }
}

//Java
class Solution {
    public String convertToTitle(int n) {
        StringBuilder sb = new StringBuilder();
        while(n != 0)
        {
            n--;
            sb.insert(0, (char) ('A'+ n%26));
            n /= 26;            
        }
        
        return sb.toString();   
    }
}