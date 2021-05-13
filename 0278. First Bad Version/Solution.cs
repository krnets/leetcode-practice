/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class VersionControl
{
    private readonly int _bad;

    public VersionControl(int bad) => _bad = bad;

    public bool IsBadVersion(int n)
    {
        return n == _bad;
    }
}

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int start = 0, end = n;

        while (start < end)
        {
            int mid = start + (end - start) / 2;

            if (IsBadVersion(mid))
                end = mid;
            else start = mid + 1;
        }

        return start;
    }

    public Solution(int bad) : base(bad)
    {
    }
}