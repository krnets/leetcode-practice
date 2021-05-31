using System;
using System.Linq;
using NUnit.Framework;
using static TreeUtils;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {3, 9, 20, null, null, 15, 7};
        int output = 3;
        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        var actual = new Solution().MaxDepth(root);
        Console.WriteLine($"tree depth {actual}");
        PrintBinaryTree(root);

        Assert.AreEqual(output, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr = {1, null, 2};
        int output = 2;
        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        var actual = new Solution().MaxDepth(root);
        Console.WriteLine($"tree depth {actual}");
        PrintBinaryTree(root);

        Assert.AreEqual(output, actual);
    }

    [Test]
    public void ExampleTest3()
    {
        int?[] rootArr = {1, 2, 3, 4, null, null, 5};
        int output = 3;
        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        var actual = new Solution().MaxDepth(root);
        Console.WriteLine($"tree depth {actual}");
        PrintBinaryTree(root);

        Assert.AreEqual(output, actual);
    }
}