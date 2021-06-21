/*public class Solution
{
    public bool DivisorGame(int n)
    {
        return n % 2 == 0;
    }
}*/

public class Solution
{
    public bool DivisorGame(int n)
    {
        return (n & 1) == 0;
    }
}
