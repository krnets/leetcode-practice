public class Solution
{
    public void ReverseString(char[] s)
    {
        int start = 0;
        int end = s.Length - 1;

        while (start < end)
        {
            // (s[start], s[end]) = (s[end], s[start]);
            char temp = s[start];
            s[start] = s[end];
            s[end] = temp;
            start++;
            end--;
        }
    }
}