using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        string[] words = {"bella", "label", "roller"};
        string[] expected = {"e", "l", "l"};
        Assert.AreEqual(expected, new Solution().CommonChars(words));
    }

    [Test]
    public void ExampleTest2()
    {
        string[] words = {"cool", "lock", "cook"};
        string[] expected = {"c", "o"};
        Assert.AreEqual(expected, new Solution().CommonChars(words));
    }
}