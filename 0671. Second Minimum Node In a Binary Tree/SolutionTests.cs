using System;
using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {2, 2, 5, null, null, 5, 7};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int actual = new Solution().FindSecondMinimumValue(root);
        int expected = 5;
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr = {2, 2, 2};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int actual = new Solution().FindSecondMinimumValue(root);
        int expected = -1;
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest3()
    {
        int?[] rootArr = {5, 8, 5};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int actual = new Solution().FindSecondMinimumValue(root);
        int expected = 8;
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