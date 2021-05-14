using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest_1()
    {
        var input = 1;
        var expected = true;
        Assert.AreEqual(expected, s.IsPowerOfTwo(input));
    }

    [Test]
    public void ExampleTest_16()
    {
        var input = 16;
        var expected = true;
        Assert.AreEqual(expected, s.IsPowerOfTwo(input));
    }

    [Test]
    public void ExampleTest_3()
    {
        var input = 3;
        var expected = false;
        Assert.AreEqual(expected, s.IsPowerOfTwo(input));
    }

    [Test]
    public void ExampleTest_4()
    {
        var input = 4;
        var expected = true;
        Assert.AreEqual(expected, s.IsPowerOfTwo(input));
    }

    [Test]
    public void ExampleTest_5()
    {
        var input = 5;
        var expected = false;
        Assert.AreEqual(expected, s.IsPowerOfTwo(input));
    }
}
