using System;
using System.Collections.Generic;
using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = "?zs";
        var expected = new List<string> {"azs"};
        var actual = new Solution().ModifyString(input);
        Assert.IsTrue(expected.Contains(actual));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "ubv?w";
        var expected = new List<string> {"ubvaw"};
        var actual = new Solution().ModifyString(input);
        Assert.IsTrue(expected.Contains(actual));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "j?qg??b";
        var expected = new List<string> {"jaqgacb", "jaqgcdb"};
        var actual = new Solution().ModifyString(input);
        Assert.IsTrue(expected.Contains(actual));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "??yw?ipkj?";
        var expected = new List<string> {"acywaipkja", "abywcipkjd"};
        var actual = new Solution().ModifyString(input);
        Console.Write(actual);
        Assert.IsTrue(expected.Contains(actual));
    }

    [Test]
    public void ExampleTest5()
    {
        var input =
            "????????????????????????????????????????????????????????????????????????????????????????????????????";
        var expected = new List<string>
        {
            "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuv"
        };
        var actual = new Solution().ModifyString(input);
        Assert.IsTrue(expected.Contains(actual));
    }
}