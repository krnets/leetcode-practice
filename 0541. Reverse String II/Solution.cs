/*using System;

public class Solution
{
    public string ReverseStr(string s, int k)
    {
        var chArr = s.ToCharArray();
        int wordStart = 0, wordEnd = s.Length - 1;

        if (k > s.Length)
        {
            ReverseSubstring(wordStart, wordEnd, chArr);
            return new string(chArr);
        }

        for (int i = 0; i < chArr.Length; i += 2 * k)
        {
            wordEnd = Math.Min(i + k - 1, chArr.Length - 1);
            ReverseSubstring(wordStart, wordEnd, chArr);
            wordStart = i + 2 * k;
        }

        return new string(chArr);
    }

    private static void ReverseSubstring(int wordStart, int wordEnd, char[] chArr)
    {
        while (wordStart < wordEnd)
        {
            (chArr[wordStart], chArr[wordEnd]) = (chArr[wordEnd], chArr[wordStart]);
            wordStart++;
            wordEnd--;
        }
    }
}*/


using System;

public class Solution
{
    public string ReverseStr(string s, int k)
    {
        char[] array = s.ToCharArray();

        for (int i = 0; i < array.Length; i += 2 * k)
        {
            int wordStart = i;
            int wordEnd = Math.Min(i + k - 1, array.Length - 1);

            while (wordStart < wordEnd)
            {
                (array[wordStart], array[wordEnd]) = (array[wordEnd], array[wordStart]);
                wordStart++;
                wordEnd--;
            }
        }

        return new string(array);
    }
}


/*public class Solution
{
    public string ReverseStr(string s, int k)
    {
        char[] array = s.ToCharArray();

        for (int i = 0; i < array.Length; i += 2 * k)
        {
            int wordStart = i;
            int wordEnd = Math.Min(i + k - 1, array.Length - 1);

            while (wordStart < wordEnd)
            {
                char temp = array[wordStart];
                array[wordStart] = array[wordEnd];
                array[wordEnd] = temp;

                wordStart++;
                wordEnd--;
            }
        }

        return new string(array);
    }
}*/