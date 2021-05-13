using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int n = 10;
        int pick = 6;
        var s = new Solution(pick);
        var expected = 6;
        Assert.AreEqual(expected, s.GuessNumber(n));
    }

    [Test]
    public void ExampleTest2()
    {
        int n = 1;
        int pick = 1;
        var s = new Solution(pick);
        var expected = 1;
        Assert.AreEqual(expected, s.GuessNumber(n));
    }

    [Test]
    public void ExampleTest3()
    {
        int n = 2;
        int pick = 1;
        var s = new Solution(pick);
        var expected = 1;
        Assert.AreEqual(expected, s.GuessNumber(n));
    }

    [Test]
    public void ExampleTest4()
    {
        int n = 2;
        int pick = 2;
        var s = new Solution(pick);
        var expected = 2;
        Assert.AreEqual(expected, s.GuessNumber(n));
    }
}