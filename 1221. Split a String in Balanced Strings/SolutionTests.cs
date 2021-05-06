using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "RLRRLLRLRL";
        var expected = 4;
        Assert.AreEqual(expected, s.BalancedStringSplit(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "RLLLLRRRLR";
        var expected = 3;
        Assert.AreEqual(expected, s.BalancedStringSplit(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "LLLLRRRR";
        var expected = 1;
        Assert.AreEqual(expected, s.BalancedStringSplit(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "RLRRRLLRLL";
        var expected = 2;
        Assert.AreEqual(expected, s.BalancedStringSplit(input));
    }
}