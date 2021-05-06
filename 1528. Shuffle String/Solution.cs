/*public class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        var chars = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
            chars[indices[i]] = s[i];

        return string.Concat(chars);
    }
}*/

public class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        char[] array = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
            array[indices[i]] = s[i];

        return new string(array);
    }
}