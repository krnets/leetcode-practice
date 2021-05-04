using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var jewels = "aA";
        var stones = "aAAbbbb";
        var expected = 3;
        Assert.AreEqual(expected, s.NumJewelsInStones(jewels, stones));
    }

    [Test]
    public void ExampleTest2()
    {
        var jewels = "z";
        var stones = "ZZ";
        var expected = 0;
        Assert.AreEqual(expected, s.NumJewelsInStones(jewels, stones));
    }
}