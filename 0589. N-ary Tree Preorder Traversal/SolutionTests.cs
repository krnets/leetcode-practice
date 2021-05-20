using System;
using System.Linq;
using NUnit.Framework;
using static TreeUtils;

public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int?[] rootArr = {1, null, 3, 2, 4, null, 5, 6};
        int?[] outputArr = {1, 3, 5, 6, 2, 4};

        // var root = new Node(1);
        // var node2 = new Node(2);
        // var node3 = new Node(3);
        // var node4 = new Node(4);
        // root.children = new List<Node> {node3, node2, node4};
        // var node5 = new Node(5);
        // var node6 = new Node(6);
        // node3.children = new List<Node> {node5, node6};

        Node root = ConstructNAryTree(rootArr.ToList());

        var expectedStr = string.Join(", ", outputArr);
        var actual = new Solution().Preorder(root);
        var actualStr = string.Join(", ", actual);

        Console.WriteLine("expected: ");
        Console.WriteLine(expectedStr);
        Console.WriteLine("actual: ");
        Console.WriteLine(actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }

    [Test]
    public void ExampleTest2()
    {
        int?[] rootArr =
        {
            1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10,
            null, null, 11, null, 12, null, 13, null, null, 14
        };
        int?[] outputArr = {1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10};

        // var root = new Node(1);
        // var node2 = new Node(2);
        // var node3 = new Node(3);
        // var node4 = new Node(4);
        // var node5 = new Node(5);
        // root.children = new List<Node> {node2, node3, node4, node5};

        // var node6 = new Node(6);
        // var node7 = new Node(7);
        // node3.children = new List<Node> {node6, node7};

        // var node8 = new Node(8);
        // node4.children = new List<Node> {node8};

        // var node9 = new Node(9);
        // var node10 = new Node(10);
        // node5.children = new List<Node> {node9, node10};

        // var node11 = new Node(11);
        // node7.children = new List<Node> {node11};

        // var node12 = new Node(12);
        // node8.children = new List<Node> {node12};

        // var node13 = new Node(13);
        // node9.children = new List<Node> {node13};

        // var node14 = new Node(14);
        // node11.children = new List<Node> {node14};

        Node root = ConstructNAryTree(rootArr.ToList());

        var expectedStr = string.Join(", ", outputArr);
        var actual = new Solution().Preorder(root);
        var actualStr = string.Join(", ", actual);

        Console.WriteLine("expected: ");
        Console.WriteLine(expectedStr);
        Console.WriteLine("actual: ");
        Console.WriteLine(actualStr);

        Assert.AreEqual(expectedStr, actualStr);
    }
}