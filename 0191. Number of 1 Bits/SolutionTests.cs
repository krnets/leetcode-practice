using NUnit.Framework;
using System;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        uint n = Convert.ToUInt32("00000000000000000000000000001011", 2);
        int expected = 3;
        Assert.AreEqual(expected, new Solution().HammingWeight(n));
    }

    [Test]
    public void ExampleTest2()
    {
        uint n = Convert.ToUInt32("00000000000000000000000010000000", 2);
        int expected = 1;
        Assert.AreEqual(expected, new Solution().HammingWeight(n));
    }

    [Test]
    public void ExampleTest3()
    {
        uint n = Convert.ToUInt32("11111111111111111111111111111101", 2);
        int expected = 31;
        Assert.AreEqual(expected, new Solution().HammingWeight(n));
    }
}