using NUnit.Framework;
using System;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        uint input = Convert.ToUInt32("00000010100101000001111010011100", 2);
        long expected = 964176192;       // 00111001011110000010100101000000
        Assert.AreEqual(expected, new Solution().reverseBits(input));
    }

    [Test]
    public void ExampleTest2()
    {
        uint input = Convert.ToUInt32("11111111111111111111111111111101", 2);
        long expected = 3221225471;       // 10111111111111111111111111111111
        Assert.AreEqual(expected, new Solution().reverseBits(input));
    }
}