public class Solution {
    public int Calculate(string s) {
        if (s == null || s.Length == 0)
            return 0;
            
        Stack<int> stack = new Stack<int>();
        char[] chars = s.ToCharArray();
        int res = 0;
        int num = 0;
        int sign = 1;
        stack.Push(sign);

        for(int i=0; i<chars.Length; i++)
        {
            if (chars[i] >= '0' && chars[i] <= '9')
            {
                num = num * 10 + (chars[i] - '0');
            }                    
            else if(chars[i]=='+' || chars[i] == '-')
            {
                res += sign * num;
                sign = stack.Peek() * (chars[i] == '+' ? 1 : -1);
                num = 0;
            }
            else if (chars[i] == '(')
            {
                stack.Push(sign);
            }
            else if (chars[i] == ')')
            {
                stack.Pop();
            }
        }
        res += sign * num;
        return res;
    }
}

//Java
class Solution {
    public int calculate(String s) {
        if (s == null || s.length() == 0) {
            return 0;
        }

        Stack<Integer> stack = new Stack<>();
        char[] chars = s.toCharArray();
        int rst = 0;
        int num = 0;
        int sign = 1;
        stack.push(sign);

        for (int i = 0; i < chars.length; i++) {
            if (chars[i] >= '0' && chars[i] <= '9') {
                num = num * 10 + (chars[i] - '0');
            } else if (chars[i] == '+' || chars[i] == '-') {
                rst += sign * num;
                sign = stack.peek() * (chars[i] == '+' ? 1 : -1);
                num = 0;
            } else if (chars[i] == '(') {
                stack.push(sign);
            } else if (chars[i] == ')') {
                stack.pop();
            }
        }

        rst += sign * num;
        return rst;
    }
}