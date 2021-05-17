using System;
using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        Solution s = new();

        int?[] root1arr = {1, 3, 2, 5};
        int?[] root2arr = {2, 1, 3, null, 4, null, 7};
        int?[] expectedArr = {3, 4, 5, 5, 4, null, 7};
        TreeNode root1 = TreeUtils.ConstructBinaryTree(root1arr.ToList());
        TreeNode root2 = TreeUtils.ConstructBinaryTree(root2arr.ToList());
        TreeNode expected = TreeUtils.ConstructBinaryTree(expectedArr.ToList());
        TreeNode actual = s.MergeTrees(root1, root2);
        var expectedStr = TreeUtils.BFSLevelOrderString(expected);
        var actualStr = TreeUtils.BFSLevelOrderString(actual);

        Console.Write("expected: ");
        Console.WriteLine(expectedStr);
        TreeUtils.PrintBinaryTree(expected);

        Console.Write("actual: ");
        Console.WriteLine(actualStr);
        TreeUtils.PrintBinaryTree(actual);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest2()
    {
        Solution s = new();

        int?[] root1arr = {1};
        int?[] root2arr = {1, 2};
        int?[] expectedArr = {2, 2};
        TreeNode root1 = TreeUtils.ConstructBinaryTree(root1arr.ToList());
        TreeNode root2 = TreeUtils.ConstructBinaryTree(root2arr.ToList());
        TreeNode expected = TreeUtils.ConstructBinaryTree(expectedArr.ToList());
        TreeNode actual = s.MergeTrees(root1, root2);
        var expectedStr = TreeUtils.BFSLevelOrderString(expected);
        var actualStr = TreeUtils.BFSLevelOrderString(actual);

        Console.Write("expected: ");
        Console.WriteLine(expectedStr);
        TreeUtils.PrintBinaryTree(expected);

        Console.Write("actual: ");
        Console.WriteLine(actualStr);
        TreeUtils.PrintBinaryTree(actual);

        Assert.AreEqual(expectedStr, actualStr);
    }
}