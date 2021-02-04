public class Trie {
    List<string> list;

    /** Initialize your data structure here. */
    public Trie() {
        list = new List<string>();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        if (!list.Contains(word))
                list.Add(word);
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        if (list.Contains(word))
                return true;
            else
                return false;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        bool res = true;                
        char[] preFixArray = prefix.ToCharArray();
        if (list.Count == 0)
            return false;
        for(int i=0;i<list.Count; i++)
        {
            char[] sArray = list[i].ToCharArray();
            res = true;
            if (sArray.Length >= preFixArray.Length)
            {
                for(int j = 0; j < preFixArray.Length; j++)
                {
                    if (!sArray[j].Equals(preFixArray[j]))
                        res = false;
                }
            }
            else
                res = false;
            if (res == true)
                break;                    
        }
        return res;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
 
 
 //Java
 class Trie {
    private Node root;
   
    private class Node {
        private boolean isWord;
        
        private HashMap<Character, Node> next;

        public Node() {
            this.isWord = false;
            this.next = new HashMap<>();
        }
    }

    /** Initialize your data structure here. */
    public Trie() {
        root = new Node();
    }
    
    /** Inserts a word into the trie. */
    public void insert(String word) {
        Node curNode = root;
        for (int i = 0; i < word.length(); i++) {
            Character c = word.charAt(i);
            if (!curNode.next.containsKey(c)) {
                curNode.next.put(c, new Node());
            }
            curNode = curNode.next.get(c);
        }        
        if (!curNode.isWord) {
            curNode.isWord = true;
        }
    }
    
    /** Returns if the word is in the trie. */
    public boolean search(String word) {
        Node curNode = root;
        for (int i = 0; i < word.length(); i++) {
            Character c = word.charAt(i);
            if (curNode.next.containsKey(c)) {
                curNode = curNode.next.get(c);
            } else {
                return false; 
            }
        }
        return curNode.isWord;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public boolean startsWith(String prefix) {
        Node curNode = root;
        for (int i = 0; i < prefix.length(); i++) {
            Character c = prefix.charAt(i);
            if (curNode.next.containsKey(c)) {
                curNode = curNode.next.get(c);
            } else {
                return false;
            }
        }        
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.insert(word);
 * boolean param_2 = obj.search(word);
 * boolean param_3 = obj.startsWith(prefix);
 */