using System;
using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {3, 1, 4, null, 2};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int k = 1;
        int actual = new Solution().KthSmallest(root, k);
        int expected = 1;
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr = {5, 3, 6, 2, 4, null, null, 1};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int k = 3;
        int actual = new Solution().KthSmallest(root, k);
        int expected = 3;
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.AreEqual(expected, actual);
    }

    private static void PrintResults(TreeNode root, string rootStr)
    {
        Console.WriteLine(rootStr);
        Console.WriteLine($"{new string('.', rootStr.Length - 1)}");
        TreeUtils.PrintBinaryTree(root);
    }
}