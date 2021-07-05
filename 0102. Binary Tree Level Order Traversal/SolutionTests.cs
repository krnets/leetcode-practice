using System;
using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {3, 9, 20, null, null, 15, 7};
        var root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        var actual = new Solution().LevelOrder(root);
        int[][] expected = {new[] {3}, new[] {9, 20}, new[] {15, 7}};
        PrintResults(root, rootStr);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr = {1};
        var root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        var actual = new Solution().LevelOrder(root);
        int[][] expected = {new[] {1}};
        PrintResults(root, rootStr);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest3()
    {
        int?[] rootArr = { };
        var root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        var actual = new Solution().LevelOrder(root);
        int[][] expected = { };
        Assert.AreEqual(expected, actual);
    }

    private static void PrintResults(TreeNode root, string rootStr)
    {
        Console.WriteLine(rootStr);
        Console.WriteLine($"{new string('.', rootStr.Length - 1)}");
        TreeUtils.PrintBinaryTree(root);
    }
}