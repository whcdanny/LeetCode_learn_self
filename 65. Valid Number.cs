public class Solution {
    public bool IsNumber(string s) {
        s = s.Trim();
        bool isNumber = false;
        int i = 0;

        if (s.Length == 0)
        {
            return false;
        }

        //parse number sign
        if (s[i] == '-' || s[i] == '+')
        {
            ++i;
        }

        //parse first number part
        while (i < s.Length && char.IsDigit(s[i]))
        {
            ++i;
            isNumber = true;
        }

        //parse dot sign
        if (i < s.Length && s[i] == '.')
        {
            ++i;

            //parse second number part
            while (i < s.Length && char.IsDigit(s[i]))
            {
                ++i;
                isNumber = true;
            }
        }

        //parse exponent
        if (isNumber && i < s.Length - 1 && s[i] == 'e')
        {
            ++i;
            isNumber = false;

            //parse exponent sign
            if (s[i] == '-' || s[i] == '+')
            {
                ++i;
            }

            //parse exponent value
            while (i < s.Length && char.IsDigit(s[i]))
            {
                ++i;
                isNumber = true;
            }
        }

        return i == s.Length && isNumber;
    }
}




???????
class Solution:
    def isNumber(self, s: str) -> bool:
        s = s.strip()
        i = 0
        isNumber = False
        
        if len(s) == 0:
            return False
        
        if s[i] == '-' or s[i]=='+':
            i+1
            
        while i<len(s) and s[i].isdigit():
            i+1
            isNumber = True
            
        if i<len(s) and s[i]=='.':
            i+1
            
            while i<len(s) and s[i].isdigit():
                i+1
                isNumber = True
                
        if isNumber and i<len(s)-1 and s[i] == 'e':
            i+1
            isNumber = False
            
            if s[i] == '-' or s[i]=='+':
                i+1
            
            while i<len(s) and s[i].isdigit():
                i+1
                isNumber = True
        
        return i == len(s) and isNumber
        
        