using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        string moves = "UD";
        bool expected = true;
        Assert.AreEqual(expected, s.JudgeCircle(moves));
    }

    [Test]
    public void ExampleTest2()
    {
        string moves = "LL";
        bool expected = false;
        Assert.AreEqual(expected, s.JudgeCircle(moves));
    }

    [Test]
    public void ExampleTest3()
    {
        string moves = "RRDD";
        bool expected = false;
        Assert.AreEqual(expected, s.JudgeCircle(moves));
    }

    [Test]
    public void ExampleTest4()
    {
        string moves = "LDRRLRUULR";
        bool expected = false;
        Assert.AreEqual(expected, s.JudgeCircle(moves));
    }
}