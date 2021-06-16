using System.Collections.Generic;
using System.Text;

/*public class Solution
{
    public string ReverseVowels(string s)
    {
        var vowels = "aeiou";
        vowels += vowels.ToUpper();
        var stack = new Stack<char>();
        var sb = new StringBuilder();

        foreach (var c in s)
            if (vowels.Contains(c))
                stack.Push(c);

        foreach (var c in s)
            sb.Append(vowels.Contains(c) ? stack.Pop() : c);

        return sb.ToString();
    }
}*/

public class Solution
{
    public string ReverseVowels(string s)
    {
        var vowels = "aeiou";
        vowels += vowels.ToUpper();
        var arr = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !vowels.Contains(arr[left]))
                left++;

            while (left < right && !vowels.Contains(arr[right]))
                right--;

            (arr[left], arr[right]) = (arr[right], arr[left]);

            left++;
            right--;
        }

        return new string(arr);
    }
}