using System;
using System.Linq;
using NUnit.Framework;
using static TreeUtils;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {1, null, 3, 2, 4, null, 5, 6};
        int output = 3;
        Node root = ConstructNAryTree(rootArr.ToList());
        var actual = new Solution().MaxDepth(root);

        Assert.AreEqual(output, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr =
        {
            1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10,
            null, null, 11, null, 12, null, 13, null, null, 14
        };
        int output = 5;
        Node root = ConstructNAryTree(rootArr.ToList());
        var actual = new Solution().MaxDepth(root);

        Assert.AreEqual(output, actual);
    }
}
