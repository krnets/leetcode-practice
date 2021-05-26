using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "aa";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().MaxLengthBetweenEqualCharacters(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "abca";
        var expected = 2;
        Assert.AreEqual(expected, new Solution().MaxLengthBetweenEqualCharacters(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "cbzxy";
        var expected = -1;
        Assert.AreEqual(expected, new Solution().MaxLengthBetweenEqualCharacters(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "cabbac";
        var expected = 4;
        Assert.AreEqual(expected, new Solution().MaxLengthBetweenEqualCharacters(input));
    }
}