using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = 234;
        var expected = 15;
        Assert.AreEqual(expected, s.SubtractProductAndSum(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 4421;
        var expected = 21;
        Assert.AreEqual(expected, s.SubtractProductAndSum(input));
    }
}