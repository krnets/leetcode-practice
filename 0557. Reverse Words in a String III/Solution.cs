/*using System.Linq;

public class Solution
{
    public string ReverseWords(string s)
    {
        return string.Join(" ", s.Split().Select(x => string.Concat(x.Reverse())));
    }
}*/

/*public class Solution
{
    public string ReverseWords(string s)
    {
        var arr = s.ToCharArray();
        int i = 0;

        while (i < s.Length)
        {
            int wordStart = i;
            int wordEnd = i;

            while (i < s.Length && s[i] != ' ')
            {
                wordEnd++;
                i++;
            }

            wordEnd--;

            while (wordStart < wordEnd)
            {
                (arr[wordStart], arr[wordEnd]) = (arr[wordEnd], arr[wordStart]);
                wordStart++;
                wordEnd--;
            }

            i++;
        }

        return new string(arr);
    }
}*/

/*using System.Text;

public class Solution
{
    public string ReverseWords(string s)
    {
        var sb = new StringBuilder();

        foreach (string word in s.Split())
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }

            sb.Append(' ');
        }

        return sb.ToString().TrimEnd();
    }
}*/

public class Solution
{
    public string ReverseWords(string s)
    {
        var chArr = s.ToCharArray();
        int wordStart = 0, wordEnd;

        for (int i = 0; i < chArr.Length; i++)
        {
            if (chArr[i] == ' ')
            {
                wordEnd = i - 1;
                ReverseOneWord(wordStart, wordEnd, chArr);
                wordStart = i + 1;
            }
        }

        ReverseOneWord(wordStart, s.Length - 1, chArr);

        return new string(chArr);
    }

    private static void ReverseOneWord(int wordStart, int wordEnd, char[] arr)
    {
        while (wordStart < wordEnd)
        {
            (arr[wordStart], arr[wordEnd]) = (arr[wordEnd], arr[wordStart]);
            wordStart++;
            wordEnd--;
        }
    }
}