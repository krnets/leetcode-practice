public class Solution
{
    public bool CheckOnesSegment(string s)
    {
        int countSegmentOnes = 0;
        int countOnes = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                countOnes++;

                if (countOnes == 1) countSegmentOnes++;
            }
            else countOnes = 0;
        }

        return countSegmentOnes == 1;
    }
}

/*public class Solution
{
    public bool CheckOnesSegment(string s)
    {
        int countSegmentOnes = 0;
        int countOnes = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                countOnes++;

                if (countOnes == 1)
                    countSegmentOnes++;

                if (countSegmentOnes > 1)
                    return false;
            }
            else countOnes = 0;
        }

        return true;
    }
}*/