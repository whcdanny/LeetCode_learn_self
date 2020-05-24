/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
 /*Given a nested list of integers, implement an iterator to flatten it.

Each element is either an integer, or a list -- whose elements may also be integers or other lists.*/
/*思路： 看看是不是list 如果“是”循环Read*/
public class NestedIterator {

    private List<Int32> items;
    private Int32 index;
    public NestedIterator(IList<NestedInteger> nestedList)
    {
        items = new List<Int32>();
        index = 0;
        Read(nestedList);
    }
    public void Read(IList<NestedInteger> list)
    {
        for(Int32 i = 0; i < list.Count; ++i)
        {
            if(list[i].IsInteger())
            {
                items.Add(list[i].GetInteger());
            }
            else
            {
                Read(list[i].GetList());
            }
        }
    }
    public bool HasNext()
    {
        if(index >= items.Count)
        {
            return false;
        }
        return true;
    }
    public int Next()
    {
        return items[index++];
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */