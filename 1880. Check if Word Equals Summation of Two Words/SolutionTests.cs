using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
[SuppressMessage("ReSharper", "CheckNamespace")]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var firstWord = "acb";
        var secondWord = "cba";
        var targetWord = "cdb";
        Assert.IsTrue(new Solution().IsSumEqual(firstWord, secondWord, targetWord));
    }

    [Test]
    public void ExampleTest2()
    {
        var firstWord = "aaa";
        var secondWord = "a";
        var targetWord = "aab";
        Assert.IsFalse(new Solution().IsSumEqual(firstWord, secondWord, targetWord));
    }

    [Test]
    public void ExampleTest3()
    {
        var firstWord = "aaa";
        var secondWord = "a";
        var targetWord = "aaaa";
        Assert.IsTrue(new Solution().IsSumEqual(firstWord, secondWord, targetWord));
    }
}