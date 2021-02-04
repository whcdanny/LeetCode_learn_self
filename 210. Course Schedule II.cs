public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<List<int>> dpList = new List<List<int>>();

        for (int i = 0; i < numCourses; ++i)
        {
            dpList.Add(new List<int>()); 
        }
            
        int[] indegree = new int[numCourses];
        for (int i = 0; i < prerequisites.Length; ++i)
        {
            int[] tempDegree = new int[2] { prerequisites[i][0], prerequisites[i][1] }; 
            dpList[tempDegree[1]].Add(tempDegree[0]);   
            ++indegree[tempDegree[0]];            
        }
            
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < numCourses; ++i)
        {
            if (indegree[i] == 0)
                queue.Enqueue(i);
        }
            
        int[] result = new int[numCourses];
        int count = 0;
        while (queue.Count > 0)
        {                 
            int toTake = queue.Dequeue();
            result[count++] = toTake;   

            foreach (int i in dpList[toTake])
            {
                --indegree[i];    
                if (indegree[i] == 0)   
                    queue.Enqueue(i);
            }
        }

        if (count != numCourses)
            return new int[0]; 

        return result;
    }
}