using System.Linq;

public class Solution
{
    public int MinPartitions(string n)
    {
        return n.Max(c => c - '0');
    }
}

/*public class Solution
{
    public int MinPartitions(string n)
    {
        return n.Max() - '0';
    }
}*/