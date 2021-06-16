/*public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        foreach (var c in letters)
            if (c > target)
                return c;

        return letters[0];
    }
}*/

public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int low = 0;
        int high = letters.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (target >= letters[mid])
                low = mid + 1;
            else high = mid - 1;
        }

        return letters[low % letters.Length];
    }
}