using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {1, 2, 3, 1};
        var expected = true;
        Assert.AreEqual(expected, s.ContainsDuplicate(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {1, 2, 3, 4};
        var expected = false;
        Assert.AreEqual(expected, s.ContainsDuplicate(input));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] input = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
        var expected = true;
        Assert.AreEqual(expected, s.ContainsDuplicate(input));
    }
}