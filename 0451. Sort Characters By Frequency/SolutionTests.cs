using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "tree";
        var expected = "eert";
        Assert.AreEqual(expected, new Solution().FrequencySort(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "cccaaa";
        var expected = "aaaccc";
        Assert.AreEqual(expected, new Solution().FrequencySort(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "Aabb";
        var expected = "bbAa";
        Assert.AreEqual(expected, new Solution().FrequencySort(input));
    }
}