public class Solution {
    public IList<int> DiffWaysToCompute(string input) {
        List<int> res = new List<int>();
        if (input == null || input.Count() == 0) 
            return res;

        for (int i = 0; i < input.Count(); i++)
        {
            char chr = input.ElementAt(i);
            if (chr == '+' || chr == '-' || chr == '*')
            {
                string part1 = input.Substring(0, i);
                string part2 = input.Substring(i + 1);
                IList<int> part1Res = DiffWaysToCompute(part1);
                IList<int> part2Res = DiffWaysToCompute(part2);

                foreach (int p1 in part1Res)
                {
                    foreach (int p2 in part2Res)
                    {
                        if (chr == '+')
                        {
                            res.Add(p1 + p2);
                        }
                        else if (chr == '-')
                        {
                            res.Add(p1 - p2);
                        }
                        else
                        {
                            res.Add(p1 * p2);
                        }
                    }
                }
            }
        }

        if (res.Count() == 0)
        {
            res.Add(Int32.Parse(input));
        }

        return res;
    }
}

//Java
class Solution {
    public List<Integer> diffWaysToCompute(String input) {
        List<Integer> res = new ArrayList<>();
        if(input == null || input.length() == 0)    return res;
        
        for(int i = 0; i < input.length(); i ++) {
            char chr = input.charAt(i);
            if(chr == '+' || chr == '-' || chr == '*') {
                String part1 = input.substring(0, i);
                String part2 = input.substring(i + 1);
                List<Integer> part1Res = diffWaysToCompute(part1);
                List<Integer> part2Res = diffWaysToCompute(part2);
                
                for(Integer p1: part1Res) {
                    for(Integer p2: part2Res) {
                        if(chr == '+') {
                            res.add(p1 + p2);
                        } else if(chr == '-') {
                            res.add(p1 - p2);
                        } else {
                            res.add(p1 * p2);
                        }
                    }
                }
            }
        }
        
        if(res.size() == 0) {
            res.add(Integer.valueOf(input));
        }
        
        return res;
    }
}