using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int input = 5;
        int bad = 4;
        var s = new Solution(bad);
        int expected = 4;
        Assert.AreEqual(expected, s.FirstBadVersion(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int input = 1;
        int bad = 1;
        var s = new Solution(bad);
        int expected = 1;
        Assert.AreEqual(expected, s.FirstBadVersion(input));
    }

    [Test]
    public void ExampleTest3()
    {
        int input = 3;
        int bad = 1;
        var s = new Solution(bad);
        int expected = 1;
        Assert.AreEqual(expected, s.FirstBadVersion(input));
    }
}