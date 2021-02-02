public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int[] indegree = new int[numCourses];
        foreach(int[] pre in prerequisites)
        {
            indegree[pre[0]]++;
        }
        Queue<int> quese = new Queue<int>();
        for(int i=0; i < numCourses; i++)
        {
            if (indegree[i] == 0)
                quese.Enqueue(i);
        }
        if (quese.Count == 0)
            return false;
        while (quese.Count != 0)
        {
            int course = quese.Dequeue();
            foreach(int[] pre in prerequisites)
            {
                if (pre[1] == course)
                {
                    indegree[pre[0]]--;
                    if (indegree[pre[0]] == 0)
                        quese.Enqueue(pre[0]);
                }
            }
        }

        foreach(int degree in indegree)
        {
            if (degree != 0)
                return false;
        }
        return true;
    }
}

//Java
class Solution {
    public boolean canFinish(int numCourses, int[][] prerequisites) {
        int[] indegree = new int[numCourses];
        for (int[] pre : prerequisites) {
            indegree[pre[0]]++;
        }
        Queue<Integer> queue = new LinkedList();
        for (int i = 0; i < numCourses; i++) {
            if (indegree[i] == 0) {
                queue.offer(i);
            }
        }
        if (queue.isEmpty()) {
            return false;
        }
        while (!queue.isEmpty()) {
            int course = queue.poll();
            for (int[] pre : prerequisites) {
                if (pre[1] == course) {
                    indegree[pre[0]]--;
                    if (indegree[pre[0]] == 0) {
                        queue.offer(pre[0]);
                    }
                }
            }
        }
        for (int degree : indegree) {
            if (degree != 0) {
                return false;
            }
        }
        return true;
    }
}