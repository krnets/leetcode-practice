public class TrieNode
{
    public bool IsWord;
    public TrieNode[] childNodes = new TrieNode[26];
}

public class Trie
{
    private TrieNode root;
    public Trie() => root = new TrieNode();

    public void Insert(string word)
    {
        TrieNode node = root;

        foreach (var c in word)
        {
            int i = c - 'a';

            node.childNodes[i] ??= new TrieNode();
            node = node.childNodes[i];
        }

        node.IsWord = true;
    }

    public bool Search(string word)
    {
        TrieNode node = root;

        foreach (var c in word)
        {
            int i = c - 'a';

            if (node.childNodes[i] == null)
                return false;

            node = node.childNodes[i];
        }

        return node.IsWord;
    }

    public bool StartsWith(string prefix)
    {
        TrieNode node = root;

        foreach (var c in prefix)
        {
            int i = c - 'a';

            if (node.childNodes[i] == null)
                return false;

            node = node.childNodes[i];
        }

        return true;
    }
}