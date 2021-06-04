using System.Linq;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] input = {1, 0, 2, 3, 0, 4, 5, 0};
        int[] expected = {1, 0, 0, 2, 3, 0, 0, 4};
        new Solution().DuplicateZeros(input);
        Assert.IsTrue(input.SequenceEqual(expected));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {1, 2, 3};
        int[] expected = {1, 2, 3};
        new Solution().DuplicateZeros(input);
        Assert.IsTrue(input.SequenceEqual(expected));
    }
}