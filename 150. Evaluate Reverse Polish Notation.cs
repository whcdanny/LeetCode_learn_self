public class Solution {
    public int EvalRPN(string[] tokens) {
        if (tokens == null)
            return 0;
        Stack<int> nums = new Stack<int>();
        for(int i=0;i<tokens.Length; i++)
        {
            if (tokens[i] == "+" || tokens[i] == "-" ||
                tokens[i] == "*" || tokens[i] == "/")
            {
                int num2 = nums.Pop();
                int num1 = nums.Pop();
                nums.Push(op(num1, num2, tokens[i]));
            }
            else
                nums.Push(Int32.Parse(tokens[i]));
        }
        return nums.Peek();
    }
    private int op(int num1, int num2, string optor)
    {
        if (optor == "+") return num1 + num2;
        else if (optor == "-") return num1 - num2;
        else if (optor == "*") return num1 * num2;
        else return num1 / num2;
    }
}

//C++
class Solution {
public:
    int evalRPN(vector<string>& tokens) {
          int len = tokens.size();
         stack<int> S;
         for(int i = 0; i < len; i++)
         {
             if(tokens[i] == "+" || tokens[i] == "-" ||
                 tokens[i] == "*" || tokens[i] == "/")
             {
                 int op2 = S.top(); S.pop();
                 int op1 = S.top(); S.pop();
                 S.push( op(op1, op2, tokens[i][0]) );
             }
             else
                 S.push(stoi(tokens[i]));
         }
         return S.top();
     }
     int op(int op1, int op2, char optor)
     {
         if(optor == '+')return op1 + op2;
         else if(optor == '-')return op1 - op2;
         else if(optor == '*')return op1 * op2;
         else return op1 / op2;
     }
    };