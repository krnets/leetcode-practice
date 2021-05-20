using System.Linq;
using NUnit.Framework;
using static TreeUtils;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {4, 2, 7, 1, 3};
        int val = 5;
        int?[] outputArr = {4, 2, 7, 1, 3, 5};

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        TreeNode expected = ConstructBinaryTree(outputArr.ToList());
        var rootStr = BFSLevelOrderString(root);
        var expectedStr = BFSLevelOrderString(expected);
        PrintResultsBefore(root, rootStr, expected, expectedStr);

        TreeNode actual = new Solution().InsertIntoBST(root, val);
        var actualStr = BFSLevelOrderString(actual);
        PrintResultsAfter(actual, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr = {40, 20, 60, 10, 30, 50, 70};
        int val = 25;
        int?[] outputArr = {40, 20, 60, 10, 30, 50, 70, null, null, 25};

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        TreeNode expected = ConstructBinaryTree(outputArr.ToList());
        var rootStr = BFSLevelOrderString(root);
        var expectedStr = BFSLevelOrderString(expected);
        PrintResultsBefore(root, rootStr, expected, expectedStr);

        TreeNode actual = new Solution().InsertIntoBST(root, val);
        var actualStr = BFSLevelOrderString(actual);
        PrintResultsAfter(actual, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest3()
    {
        int?[] rootArr = {4, 2, 7, 1, 3, null, null, null, null, null, null};
        int val = 5;
        int?[] outputArr = {4, 2, 7, 1, 3, 5};
        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        TreeNode expected = ConstructBinaryTree(outputArr.ToList());

        var rootStr = BFSLevelOrderString(root);
        var expectedStr = BFSLevelOrderString(expected);
        PrintResultsBefore(root, rootStr, expected, expectedStr);

        TreeNode actual = new Solution().InsertIntoBST(root, val);
        var actualStr = BFSLevelOrderString(actual);
        PrintResultsAfter(actual, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }
}