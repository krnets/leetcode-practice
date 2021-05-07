/*public class Solution
{
    public string ToLowerCase(string str)
    {
        char[] array = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
            if (str[i] >= 'A' && str[i] <= 'Z')
                array[i] = (char) (str[i] + 32);
            else array[i] = str[i];

        return new string(array);
    }
}*/

/*using System.Text;

public class Solution
{
    public string ToLowerCase(string str)
    {
        var sb = new StringBuilder();

        foreach (char c in str)
            if (c >= 'A' && c <= 'Z')
                sb.Append((char) (c + 32));
            else sb.Append(c);

        return sb.ToString();
    }
}*/

using System.Text;

public class Solution
{
    public string ToLowerCase(string str)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];

            if (c >= 'A' && c <= 'Z')
                sb.Append((char) (c + 32));
            else sb.Append(c);
        }

        return sb.ToString();
    }
}