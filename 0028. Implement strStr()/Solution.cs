/*public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length == 0) return 0;

        var c = needle[0];

        for (int i = 0; i < haystack.Length; i++)
            if (haystack[i] == c)
            {
                if (haystack.Length - needle.Length < i)
                    return -1;

                if (haystack[i..(i + needle.Length)] == needle)
                    return i;
            }

        return -1;
    }
}*/

/*public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length == 0) return 0;

        for (int i = 0; i < haystack.Length; i++)
            if (haystack[i] == needle[0])
            {
                if (haystack.Length - needle.Length < i)
                    return -1;

                if (haystack[i..(i + needle.Length)] == needle)
                    return i;
            }

        return -1;
    }
}*/

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle)) return 0;

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
            if (haystack.Substring(i, needle.Length) == needle)
                return i;

        return -1;
    }
}