public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Trim().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();            
            for(int i=words.Length-1; i >= 0; i--)
            {
                sb.Append(words[i]).Append(" ");
            }            
            return sb.ToString().Trim();
    }
}

//Java
class Solution {
    public String reverseWords(String s) {
        String[] words = s.trim().split("\\s+");
        StringBuilder sb = new StringBuilder();
        for(int i = words.length - 1; i >= 0; i--) {
            sb.append(words[i]).append(" ");
        }
        return sb.toString().trim();
    }
}