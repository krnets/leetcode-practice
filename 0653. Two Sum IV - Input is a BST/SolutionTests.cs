using System;
using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {5, 3, 6, 2, 4, null, 7};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int k = 9;
        bool actual = new Solution().FindTarget(root, k);
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.True(actual);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr = {5, 3, 6, 2, 4, null, 7};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int k = 28;
        bool actual = new Solution().FindTarget(root, k);
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.False(actual);
    }

    [Test]
    public void ExampleTest3()
    {
        int?[] rootArr = {2, 1, 3};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int k = 4;
        bool actual = new Solution().FindTarget(root, k);
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.True(actual);
    }

    [Test]
    public void ExampleTest4()
    {
        int?[] rootArr = {2, 1, 3};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int k = 1;
        bool actual = new Solution().FindTarget(root, k);
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.False(actual);
    }

    [Test]
    public void ExampleTest5()
    {
        int?[] rootArr = {2, 1, 3};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int k = 3;
        bool actual = new Solution().FindTarget(root, k);
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.True(actual);
    }

    private static void PrintResults(TreeNode root, string rootStr)
    {
        Console.WriteLine(rootStr);
        Console.WriteLine($"{new string('.', rootStr.Length - 1)}");
        TreeUtils.PrintBinaryTree(root);
    }
}