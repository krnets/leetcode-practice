/*using System.Linq;

public class Solution
{
    public string SortSentence(string s)
    {
        return string.Join(" ", s.Split()
            .Select(w => new[] {w[..^1], w[^1].ToString()})
            .OrderBy(arr => int.Parse(arr[1]))
            .Select(arr => arr[0]));
    }
}*/


using System;

public class Solution
{
    public string SortSentence(string s)
    {
        string[] arr = s.Split();
        Array.Sort(arr, (a, b) => int.Parse(a[^1].ToString()) - int.Parse(b[^1].ToString()));

        for (int i = 0; i < arr.Length; i++) 
            arr[i] = arr[i][..^1];

        return string.Join(" ", arr);
    }
}