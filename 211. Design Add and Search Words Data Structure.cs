public class WordDictionary {
    List<string> list;

    /** Initialize your data structure here. */
    public WordDictionary() {
        list = new List<string>();
    }
    
    public void AddWord(string word) {
        if (!list.Contains(word))
            list.Add(word);
    }
    
    public bool Search(string word) {
        bool res = true;
        char[] wordArray = word.ToCharArray();
        if (list.Count == 0)
            return false;
        for(int i = 0; i<list.Count; i++)
        {
            res = true;
            char[] listArray = list[i].ToCharArray();
            if (listArray.Length == wordArray.Length)
            {
                for (int j = 0; j < wordArray.Length; j++)
                {
                    if (wordArray[j] != '.')
                    {
                        if (listArray[j] != wordArray[j])
                        {
                            res = false;                                   
                        }
                    }
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
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
 
 //Java
 public class WordDictionary {
    private TrieNode root;
    
    public WordDictionary() {
        this.root = new TrieNode();
    }
   
    public void addWord(String word) {
        TrieNode currentNode = root;
        for (int i = 0; i < word.length(); i++) {
            currentNode = currentNode.addLetter(word.charAt(i));
        }
        currentNode.setIsWord();
    }
   
    public boolean search(String word) {
        return search(word, 0, root);
    }
    
    private boolean search(String word, int index, TrieNode node) {
        if (index == word.length()) {
            return node.isWord();
        }
        if ('.' == word.charAt(index)) {
            for (TrieNode child : node.getAllChildren()) {
                if (search(word, index + 1, child)) {
                    return true;
                }
            }
        } else {
            TrieNode child = node.getChild(word.charAt(index));
            if (child != null) {
                return search(word, index + 1, child);
            }
        }
        return false;
    }
}

class TrieNode {    
    private Map<Character, TrieNode> children;
    private boolean isWord;

    public TrieNode() {
        this.children = new HashMap<>();
    }
    
    TrieNode addLetter(Character letter) {
        if (!children.containsKey(letter)) {
            children.put(letter, new TrieNode());
        }
        return children.get(letter);
    }
    
    TrieNode getChild(Character letter) {
        return children.get(letter);
    }
    
    void setIsWord() {
        isWord = true;
    }
    
    boolean isWord() {
        return isWord;
    }
    
    List<TrieNode> getAllChildren() {
        return new ArrayList<TrieNode>(children.values());
    }
}

// Your WordDictionary object will be instantiated and called as such:
// WordDictionary wordDictionary = new WordDictionary();
// wordDictionary.addWord("word");
// wordDictionary.search("pattern");