using System.Linq;
using NUnit.Framework;
using static TreeUtils;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {1, null, 2, 3};
        int?[] outputArr = {1, 2, 3};

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        var expectedStr = string.Join(", ", outputArr);
        var actual = new Solution().PreorderTraversal(root);
        var actualStr = string.Join(", ", actual);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr = { };
        int?[] outputArr = { };

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        var expectedStr = string.Join(", ", outputArr);
        var actual = new Solution().PreorderTraversal(root);
        var actualStr = string.Join(", ", actual);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest3()
    {
        int?[] rootArr = {1};
        int?[] outputArr = {1};

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        var expectedStr = string.Join(", ", outputArr);
        var actual = new Solution().PreorderTraversal(root);
        var actualStr = string.Join(", ", actual);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest4()
    {
        int?[] rootArr = {1, 2};
        int?[] outputArr = {1, 2};

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        var expectedStr = string.Join(", ", outputArr);
        var actual = new Solution().PreorderTraversal(root);
        var actualStr = string.Join(", ", actual);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest5()
    {
        int?[] rootArr = {1, null, 2};
        int?[] outputArr = {1, 2};

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        var expectedStr = string.Join(", ", outputArr);
        var actual = new Solution().PreorderTraversal(root);
        var actualStr = string.Join(", ", actual);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest6()
    {
        int?[] rootArr = {3, 1, 2};
        int?[] outputArr = {3, 1, 2};

        TreeNode root = ConstructBinaryTree(rootArr.ToList());
        var expectedStr = string.Join(", ", outputArr);
        var actual = new Solution().PreorderTraversal(root);
        var actualStr = string.Join(", ", actual);

        Assert.AreEqual(expectedStr, actualStr);
    }
}