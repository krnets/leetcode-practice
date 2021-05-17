/*
public class Solution
{
    public string GenerateTheString(int n)
    {
        return n % 2 == 0 ? $"{new string('a', n - 1)}b" : new string('a', n);
    }
}
*/


public class Solution
{
    public string GenerateTheString(int n)
    {
        char[] array = new char[n];

        for (int i = 0; i < n; i++)
            array[i] = 'a';

        if (n % 2 == 0)
            array[0] = 'b';

        return new string(array);
    }
}