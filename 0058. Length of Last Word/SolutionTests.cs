using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "Hello World";
        var expected = 5;
        Assert.AreEqual(expected, new Solution().LengthOfLastWord(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = " ";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().LengthOfLastWord(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "a ";
        var expected = 1;
        Assert.AreEqual(expected, new Solution().LengthOfLastWord(input));
    }
}