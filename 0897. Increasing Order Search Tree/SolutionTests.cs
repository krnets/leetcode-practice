using System;
using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    private static void PrintResults(TreeNode root, string rootStr, TreeNode expected, string expectedStr,
        TreeNode actual, string actualStr)
    {
        Console.Write("original: ");
        Console.WriteLine(rootStr);
        TreeUtils.PrintBinaryTree(root);

        Console.Write("expected: ");
        Console.WriteLine(expectedStr);
        TreeUtils.PrintBinaryTree(expected);

        Console.Write("actual: ");
        Console.WriteLine(actualStr);
        TreeUtils.PrintBinaryTree(actual);
    }

    [Test]
    public void ExampleTest1()
    {
        Solution s = new();

        int?[] rootArr = {5, 3, 6, 2, 4, null, 8, 1, null, null, null, 7, 9};
        int?[] outputArr = {1, null, 2, null, 3, null, 4, null, 5, null, 6, null, 7, null, 8, null, 9};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        TreeNode expected = TreeUtils.ConstructBinaryTree(outputArr.ToList());
        TreeNode actual = s.IncreasingBST(root);
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        var expectedStr = TreeUtils.BFSLevelOrderString(expected);
        var actualStr = TreeUtils.BFSLevelOrderString(actual);
        PrintResults(root, rootStr, expected, expectedStr, actual, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }


    [Test]
    public void ExampleTest2()
    {
        Solution s = new();

        int?[] rootArr = {5, 1, 7};
        int?[] outputArr = {1, null, 5, null, 7};
        TreeNode root = TreeUtils.ConstructBinaryTree(rootArr.ToList());
        TreeNode expected = TreeUtils.ConstructBinaryTree(outputArr.ToList());
        TreeNode actual = s.IncreasingBST(root);
        var rootStr = TreeUtils.BFSLevelOrderString(root);
        var expectedStr = TreeUtils.BFSLevelOrderString(expected);
        var actualStr = TreeUtils.BFSLevelOrderString(actual);
        PrintResults(root, rootStr, expected, expectedStr, actual, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }
}