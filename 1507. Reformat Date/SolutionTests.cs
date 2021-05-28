using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var date = "20th Oct 2052";
        var expected = "2052-10-20";
        Assert.AreEqual(expected, new Solution().ReformatDate(date));
    }

    [Test]
    public void ExampleTest2()
    {
        var date = "6th Jun 1933";
        var expected = "1933-06-06";
        Assert.AreEqual(expected, new Solution().ReformatDate(date));
    }

    [Test]
    public void ExampleTest3()
    {
        var date = "26th May 1960";
        var expected = "1960-05-26";
        Assert.AreEqual(expected, new Solution().ReformatDate(date));
    }
}