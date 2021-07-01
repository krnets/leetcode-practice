/*public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        int ones = 0;

        for (int i = bits.Length - 2; i >= 0 && bits[i] != 0; i--)
            ones++;

        return ones % 2 == 0;
    }
}*/

/*public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        bool ans = false;

        for (int i = 0; i < bits.Length; i++)
        {
            if (bits[i] == 1)
            {
                ans = false;
                i++;
            }
            else ans = true;
        }

        return ans;
    }
}*/

public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        int i = 0;
        int length = bits.Length - 1;

        while (i < length)
        {
            i += (bits[i] == 1 ? 2 : 1);
        }

        return i == length;
    }
}