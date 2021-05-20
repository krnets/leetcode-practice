using System.Linq;
using NUnit.Framework;
using static TreeUtils;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {4, 2, 7, 1, 3};
        int val = 2;
        int?[] outputArr = {2, 1, 3};

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        TreeNode expected = ConstructBinaryTree(outputArr.ToList());
        TreeNode actual = new Solution().SearchBST(root, val);

        var rootStr = BFSLevelOrderString(root);
        var expectedStr = BFSLevelOrderString(expected);
        var actualStr = BFSLevelOrderString(actual);

        PrintResults(root, rootStr, expected, expectedStr, actual, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr = {4, 2, 7, 1, 3};
        int val = 5;

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        TreeNode expected = ConstructBinaryTree(null);
        TreeNode actual = new Solution().SearchBST(root, val);

        var rootStr = BFSLevelOrderString(root);
        var expectedStr = BFSLevelOrderString(expected);
        var actualStr = BFSLevelOrderString(actual);

        PrintResults(root, rootStr, expected, expectedStr, actual, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest3()
    {
        int?[] rootArr = {62, 2, 93, null, 30, null, null, 15, null, null, null};
        int val = 15;
        int?[] outputArr = {15};

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        TreeNode expected = ConstructBinaryTree(outputArr.ToList());
        TreeNode actual = new Solution().SearchBST(root, val);

        var rootStr = BFSLevelOrderString(root);
        var expectedStr = BFSLevelOrderString(expected);
        var actualStr = BFSLevelOrderString(actual);

        PrintResults(root, rootStr, expected, expectedStr, actual, actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }
}