using System.Collections.Generic;
using System.Linq;
using System.Text;

/*public class Solution
{
    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var words = sentence.Split();

        foreach (var root in dictionary)
            for (int i = 0; i < words.Length; i++)
                if (words[i].StartsWith(root))
                    words[i] = root;

        return string.Join(" ", words);
    }
}*/


public class Solution
{
    public class TrieNode
    {
        public char Value;
        public TrieNode[] Children;
        public bool IsWord;

        public TrieNode(char value)
        {
            Value = value;
            Children = new TrieNode[26];
            IsWord = false;
        }
    }

    private static TrieNode BuildTrie(IList<string> dict)
    {
        var root = new TrieNode(' ');

        foreach (var word in dict)
        {
            var node = root;

            foreach (var c in word)
            {
                int i = c - 'a';
                node.Children[i] ??= new TrieNode(c);
                node = node.Children[i];
            }

            node.IsWord = true;
        }

        return root;
    }

    private static string ReplaceWithShortest(string word, TrieNode root)
    {
        var sb = new StringBuilder();
        var node = root;

        foreach (char c in word)
        {
            int i = c - 'a';

            if (node.Children[i] == null)
                break;

            sb.Append(c);

            if (node.Children[i].IsWord)
            {
                word = sb.ToString();
                break;
            }

            node = node.Children[i];
        }

        return word;
    }

    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var trie = BuildTrie(dictionary);
        var words = sentence.Split().Select(word => ReplaceWithShortest(word, trie));

        return string.Join(" ", words);
    }
}