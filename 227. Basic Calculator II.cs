public class Solution {
    public int Calculate(string s) {
        if (s == null || s.Length == 0)
            return 0;
        Stack<int> stack = new Stack<int>();
        char[] chars = s.ToCharArray();
        int num = 0;
        char sign = '+';
        int res = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            if (Char.IsDigit(chars[i])){
                num = num * 10 + (chars[i] - '0');
            }
            if((!Char.IsDigit(chars[i])) && ' '!=chars[i] || i == s.Length - 1)
            {
                if (sign == '+')
                    stack.Push(num);
                else if (sign == '-')
                    stack.Push(-num);
                else if (sign == '/')
                    stack.Push(stack.Pop() / num);
                else if (sign == '*')
                    stack.Push(stack.Pop() * num);
                sign = chars[i];
                num = 0;
            }                
        }
        while (stack.Count != 0)
            res += stack.Pop();
        return res;
    }
}

//Java
class Solution {
    public int calculate(String s) {
        if (s == null || s.length() == 0) {
            return 0;
        }
        int len = s.length();
        Deque<Integer> stack = new ArrayDeque<>();
        int num = 0;
        char sign = '+';
        for (int i = 0; i < len; i++) {
            if (Character.isDigit(s.charAt(i))) {
                num = num * 10 + s.charAt(i) - '0';
            }
            if ((!Character.isDigit(s.charAt(i))) && ' ' != s.charAt(i) || i == len - 1) {
                if (sign == '+') {
                    stack.addLast(num);
                } else if (sign == '-') {
                    stack.addLast(-num);
                } else if (sign == '/') {
                    stack.addLast(stack.pollLast() / num);
                } else if (sign == '*') {
                    stack.addLast(stack.pollLast() * num);
                }
                sign = s.charAt(i);
                num = 0;
            }
        }
        int result = 0;
        while (!stack.isEmpty()) {
            result += stack.poll();
        }
        return result;
    }
}