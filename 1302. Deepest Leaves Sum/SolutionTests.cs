using System;
using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int expected = 15;
        int actual = new Solution().DeepestLeavesSum(root);
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr = {6, 7, 8, 2, 7, 1, 3, 9, null, 1, 4, null, null, null, 5};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        int expected = 19;
        int actual = new Solution().DeepestLeavesSum(root);
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        PrintResults(root, rootStr);
        Assert.AreEqual(expected, actual);
    }

    private static void PrintResults(TreeNode root, string rootStr)
    {
        Console.WriteLine(rootStr);
        Console.WriteLine($"{new string('.', rootStr.Length-1)}");
        TreeUtils.PrintBinaryTree(root);
    }
}