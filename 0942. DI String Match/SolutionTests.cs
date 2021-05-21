using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        string input = "IDID";
        int[] expected = {0, 4, 1, 3, 2};
        Assert.AreEqual(expected, new Solution().DiStringMatch(input));
    }

    [Test]
    public void ExampleTest2()
    {
        string input = "III";
        int[] expected = {0, 1, 2, 3};
        Assert.AreEqual(expected, new Solution().DiStringMatch(input));
    }

    [Test]
    public void ExampleTest3()
    {
        string input = "DDI";
        int[] expected = {3, 2, 0, 1};
        Assert.AreEqual(expected, new Solution().DiStringMatch(input));
    }
}