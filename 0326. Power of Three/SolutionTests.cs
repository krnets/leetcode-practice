using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = 27;
        var expected = true;
        Assert.AreEqual(expected, s.IsPowerOfThree(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 0;
        var expected = false;
        Assert.AreEqual(expected, s.IsPowerOfThree(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = 9;
        var expected = true;
        Assert.AreEqual(expected, s.IsPowerOfThree(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = 45;
        var expected = false;
        Assert.AreEqual(expected, s.IsPowerOfThree(input));
    }
}