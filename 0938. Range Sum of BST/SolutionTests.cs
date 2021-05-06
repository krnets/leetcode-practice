using System.Linq;
using NUnit.Framework;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        Solution s = new();

        int low = 7;
        int high = 15;
        int expected = 32;

        /*
        TreeNode root = new TreeNode(10,
            new TreeNode(5,
                new TreeNode(3),
                new TreeNode(7)),
            new TreeNode(15,
                null,
                new TreeNode(18)));
                */

        int?[] array = {10, 5, 15, 3, 7, null, 18};
        TreeNode root = TreeUtils.ConstructBinaryTree(array.ToList());
        TreeUtils.PrintBinaryTree(root);
        // root.Print();
        Assert.AreEqual(expected, s.RangeSumBST(root, low, high));
    }

    [Test]
    public void ExampleTest2()
    {
        Solution s = new();

        int low = 6;
        int high = 10;
        int expected = 23;

        /*
        TreeNode root = new TreeNode(10,
            new TreeNode(5,
                new TreeNode(3,
                    new TreeNode(1)),
                new TreeNode(7,
                    new TreeNode(6))),
            new TreeNode(15,
                new TreeNode(13),
                new TreeNode(18)));
                */

        int?[] array = {10, 5, 15, 3, 7, 13, 18, 1, null, 6};
        TreeNode root = TreeUtils.ConstructBinaryTree(array.ToList());
        TreeUtils.PrintBinaryTree(root);

        Assert.AreEqual(expected, s.RangeSumBST(root, low, high));
    }
}