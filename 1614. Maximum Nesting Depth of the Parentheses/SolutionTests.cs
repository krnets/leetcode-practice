using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "(1+(2*3)+((8)/4))+1";
        var expected = 3;
        Assert.AreEqual(expected, s.MaxDepth(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "(1) + ((2)) + (((3)))";
        var expected = 3;
        Assert.AreEqual(expected, s.MaxDepth(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "1+(2*3)/(2-1)";
        var expected = 1;
        Assert.AreEqual(expected, s.MaxDepth(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "1";
        var expected = 0;
        Assert.AreEqual(expected, s.MaxDepth(input));
    }
}