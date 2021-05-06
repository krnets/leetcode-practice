using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {1, 2, 3, 4};
        int[] expected = {2, 4, 4, 4};
        Assert.AreEqual(expected, s.DecompressRLElist(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {1, 1, 2, 3};
        int[] expected = {1, 3, 3};
        Assert.AreEqual(expected, s.DecompressRLElist(input));
    }
}