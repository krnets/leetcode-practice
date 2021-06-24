/*public class Solution
{
    public int NumMatchingSubseq(string s, string[] words)
    {
        int count = 0;

        foreach (var word in words)
        {
            int pos = 0;

            foreach (char c in s)
                if (pos < word.Length && c == word[pos])
                    pos++;

            if (pos == word.Length)
                count++;
        }

        return count;
    }
}*/

using System.Collections.Generic;

/*public class Solution
{
    private class Node
    {
        public string Word;
        public int Index;
    }

    public int NumMatchingSubseq(string s, string[] words)
    {
        var letters = new List<Node>[26];
        int matches = 0;

        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = new List<Node>();
        }

        foreach (var word in words)
        {
            int i = word[0] - 'a';
            var node = new Node {Word = word, Index = 0};

            letters[i].Add(node);
        }

        foreach (var c in s)
        {
            int i = c - 'a';
            var listNodes = letters[i];
            letters[i] = new List<Node>();

            foreach (var node in listNodes)
            {
                node.Index++;

                if (node.Word.Length == node.Index)
                {
                    matches++;
                }
                else
                {
                    i = node.Word[node.Index] - 'a';
                    letters[i].Add(node);
                }
            }
        }

        return matches;
    }
}*/

public class Solution
{
    public int NumMatchingSubseq(string s, string[] words)
    {
        var letters = new List<IEnumerator<char>>[26];
        int matches = 0;

        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = new List<IEnumerator<char>>();
        }

        foreach (var word in words)
        {
            var charEnum = word.GetEnumerator();

            if (charEnum.MoveNext() == false)
                return 0;

            int i = charEnum.Current - 'a';

            letters[i].Add(charEnum);
        }

        foreach (var c in s)
        {
            int i = c - 'a';
            var list = letters[i];
            letters[i] = new List<IEnumerator<char>>();

            foreach (var item in list)
            {
                if (item.MoveNext() == false)
                    matches++;
                else
                {
                    i = item.Current - 'a';
                    letters[i].Add(item);
                }
            }
        }

        return matches;
    }
}