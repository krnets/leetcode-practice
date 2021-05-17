using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var left = 1;
        var right = 22;
        int[] expected = {1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22};
        Assert.AreEqual(expected, s.SelfDividingNumbers(left, right));
    }
}