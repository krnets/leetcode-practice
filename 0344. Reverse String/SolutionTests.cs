using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        char[] input = {'h', 'e', 'l', 'l', 'o'};
        char[] expected = {'o', 'l', 'l', 'e', 'h'};
        new Solution().ReverseString(input);
        Assert.AreEqual(expected, input);
    }

    [Test]
    public void ExampleTest2()
    {
        char[] input = {'H', 'a', 'n', 'n', 'a', 'h'};
        char[] expected = {'h', 'a', 'n', 'n', 'a', 'H'};
        new Solution().ReverseString(input);
        Assert.AreEqual(expected, input);
    }
}