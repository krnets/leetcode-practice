public class Solution
{
    public int[] NumberOfLines(int[] widths, string s)
    {
        int lines = 1;
        int pixels = 0;

        foreach (char c in s)
        {
            var width = widths[c - 'a'];
            pixels += width;

            if (pixels > 100)
            {
                pixels = width;
                lines++;
            }
        }
        
        return new []{lines, pixels};
    }
}