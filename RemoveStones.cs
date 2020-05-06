/*
在二维平面上，我们将石头放置在一些整数坐标点上。每个坐标点上最多只能有一块石头。
现在，move 操作将会移除与网格上的某一块石头共享一列或一行的一块石头。
我们最多能执行多少次 move 操作？
 
示例 1：
输入：stones = [[0,0],[0,1],[1,0],[1,2],[2,1],[2,2]]
输出：5
示例 2：
输入：stones = [[0,0],[0,2],[1,1],[2,0],[2,2]]
输出：3
示例 3：
输入：stones = [[0,0]]
输出：0
*/

public class Solution {
    public int RemoveStones(int[][] stones) {
        int len = stones.Length;

        List<int>[] graph = new List<int>[len];
        for (int i = 0; i < len; i++)
            for (int j = i + 1; j < len; j++)
                if (stones[i][0] == stones[j][0] || stones[i][1] == stones[j][1])
                {
                    if (graph[i] == null) graph[i] = new List<int>();
                    if (graph[j] == null) graph[j] = new List<int>();

                    graph[i].Add(j);
                    graph[j].Add(i);
                }

        int ret = 0;
        bool[] seen = new bool[len];
        Array.Fill(seen, false);
        var stack = new Stack<int>();

        for (int i = 0; i < len; ++i) 
            if (!seen[i])
            {
                stack.Push(i);
                seen[i] = true;
                ret--;

                while ( 0 < stack.Count )
                {
                    int node = stack.Pop();
                    ret++;

                    if(graph[node] != null)
                        foreach (int neighbor in graph[node])
                        {
                            if (!seen[neighbor])
                            {
                                stack.Push(neighbor);
                                seen[neighbor] = true;
                            }
                        }
                }
            }

        return ret;
    }
}