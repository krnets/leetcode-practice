/*public class Solution
{
    public string ReplaceDigits(string s)
    {
        var array = s.ToCharArray();

        for (int i = 0; i < s.Length; i++)
            if (char.IsDigit(s[i]))
                array[i] = (char) (array[i - 1] + char.GetNumericValue(s[i]));

        return new string(array);
    }
}*/

public class Solution
{
    public string ReplaceDigits(string s)
    {
        var array = s.ToCharArray();

        for (int i = 1; i < s.Length; i += 2)
            array[i] = (char) (array[i - 1] + s[i] - '0');

        return new string(array);
    }
}