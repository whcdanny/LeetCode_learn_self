public class Solution {
    public IList<int> GrayCode(int n) {
        IList<int> result = new List<int>();
        int index = 1;

        if (n == 0)
            result.Add(0);
        else
        {
            result.Add(0);
            result.Add(1);                

            while (index < n)
            {
                for (int i = result.Count() - 1; i >= 0; i--)
                    result.Add((1 << index) + result[i]);

                index++;
            }
        }

        return result;
    }
}