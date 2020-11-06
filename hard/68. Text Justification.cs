public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        IList<string> res = new List<string>();
            IList<string> newWords = new List<string>();
            int sum = 0;
            bool match = false;//是否刚好这一行最后一个是单词
            for (int i = 0; i < words.Length; i++)
            {
                int l = words[i].Length;
                sum += l;
                if (sum > maxWidth)
                {
                    if(match)
                        sum = sum - l - newWords.Count+1;
                    else
                        sum = sum - l - newWords.Count;                    
                    int spaceNumber = maxWidth - sum;
                    
                    var newString = new StringBuilder();
                    if (newWords.Count == 1)
                    {
                        newString.Append(newWords[0]);
                        newString.Append(' ', spaceNumber);
                    }
                    else
                    {
                        int avgSpace = spaceNumber / (newWords.Count - 1);
                        int extraSpace = spaceNumber % (newWords.Count - 1);
                        for (int j = 0; j < newWords.Count; j++)
                        {
                            if (extraSpace != 0)
                            {
                                newString.Append(newWords[j]);
                                newString.Append(' ', avgSpace + 1);
                                extraSpace--;
                            }                            
                            else if (j == newWords.Count - 1)
                            {
                                newString.Append(newWords[j]);
                            }
                            else
                            {
                                newString.Append(newWords[j]);
                                newString.Append(' ', avgSpace);
                            }
                        }
                    }
                    res.Add(newString.ToString());

                    newWords.Clear();
                    newWords.Add(words[i]);
                    sum = 0;
                    sum = l+1;
                    match = false;
                                     
                }
                else if(sum == maxWidth)
                {
                    newWords.Add(words[i]);
                    match = true;
                }
                else
                {
                    newWords.Add(words[i]);
                    sum++;
                }                
            }
            if (newWords.Count > 0)
            {
                var newString = new StringBuilder();
                for (var i = 0; i < newWords.Count; i++)
                {
                    newString.Append(newWords[i]);
                    if (i < newWords.Count - 1)
                    {
                        newString.Append(' ');
                    }
                    else
                    {
                        newString.Append(' ', maxWidth - newString.Length);
                    }
                }
                res.Add(newString.ToString());
            }
            return res;
    }
}