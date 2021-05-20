using System;
using System.Collections.Generic;
// using System.Linq;
using System.Text;

public class TreeUtils
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;
        public Node(int _val) => val = _val;

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public static Node ConstructNAryTree(List<int?> list)
    {
        if (list == null || list.Count == 0)
            return null;

        // Node root = new Node((int) list.First());
        // Node root = new Node((int) list[0]);
        Node root = new Node((int) list[0], new List<Node>());
        var queue = new Queue<Node>();
        queue.Enqueue(root);

        Node currNode = null;

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] == null)
            {
                currNode = queue.Dequeue();
                continue;
            }

            // currNode.children ??= new List<Node>();
            // var child = new Node(list[i].Value);
            var child = new Node(list[i].Value, new List<Node>());
            currNode.children.Add(child);
            queue.Enqueue(child);
        }

        return root;
    }

    public static TreeNode ConstructBinaryTree(List<int?> list)
    {
        if (list == null || list.Count == 0)
            return null;

        // TreeNode root = new TreeNode((int) list.First());
        TreeNode root = new TreeNode((int) list[0]);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        for (int i = 1; i < list.Count; i++)
        {
            var currNode = queue.Dequeue();

            // if (list.ElementAt(i) != null)
            if (list[i] != null)
            {
                // currNode.left = new TreeNode((int) list.ElementAt(i));
                currNode.left = new TreeNode((int) list[i]);
                queue.Enqueue(currNode.left);
            }

            // if (++i < list.Count && list.ElementAt(i) != null)
            if (++i < list.Count && list[i] != null)
            {
                // currNode.right = new TreeNode((int) list.ElementAt(i));
                currNode.right = new TreeNode((int) list[i]);
                queue.Enqueue(currNode.right);
            }
        }

        return root;
    }

    public static string BFSLevelOrderString(TreeNode root)
    {
        if (root == null)
            return string.Empty;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var sb = new StringBuilder();

        while (queue.Count != 0)
        {
            TreeNode tempNode = queue.Dequeue();
            // Console.Write(tempNode.val + " ");
            sb.Append(tempNode.val + " ");

            if (tempNode.left != null) queue.Enqueue(tempNode.left);
            if (tempNode.right != null) queue.Enqueue(tempNode.right);
        }

        return sb.ToString();
    }

    public static void PrintBinaryTree(TreeNode root)
    {
        PrintNodeInternal(new List<TreeNode> {root}, 1, MaxLevel(root));
    }

    private static int MaxLevel(TreeNode root)
    {
        return root == null ? 0 : 1 + Math.Max(MaxLevel(root.left), MaxLevel(root.right));
    }

    private static void PrintNodeInternal(List<TreeNode> list, int level, int maxLevel)
    {
        // if (list.Count == 0 || list.All(x => x == null))
        if (list.Count == 0)
            return;

        int floor = maxLevel - level;
        int edgeLines = (int) Math.Pow(2, Math.Max(floor - 1, 0));
        int firstSpaces = (int) Math.Pow(2, floor) - 1;
        int betweenSpaces = (int) Math.Pow(2, floor + 1) - 1;

        Console.Write(new string(' ', firstSpaces));

        var newNodes = new List<TreeNode>();

        foreach (var treeNode in list)
        {
            if (treeNode != null)
            {
                Console.Write(treeNode.val);
                newNodes.Add(treeNode.left);
                newNodes.Add(treeNode.right);
            }
            else
            {
                newNodes.Add(null);
                newNodes.Add(null);
                Console.Write(' ');
            }

            Console.Write(new string(' ', betweenSpaces));
        }

        Console.WriteLine();

        for (int i = 1; i <= edgeLines; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                Console.Write(new string(' ', Math.Max(0, firstSpaces - i)));
                // if (list.ElementAt(j) == null)
                if (list[j] == null)
                {
                    Console.Write(new string(' ', edgeLines + edgeLines + i + 1));
                    continue;
                }

                // Console.Write(list.ElementAt(j).left == null ? new string(' ', 1) : "/");
                Console.Write(list[j].left == null ? new string(' ', 1) : "/");
                Console.Write(new string(' ', i + i - 1));
                // Console.Write(list.ElementAt(j).right == null ? new string(' ', 1) : "\\");
                Console.Write(list[j].right == null ? new string(' ', 1) : "\\");
                Console.Write(new string(' ', edgeLines + edgeLines - i));
            }

            Console.WriteLine();
        }

        PrintNodeInternal(newNodes, level + 1, maxLevel);
    }

    public static void PrintResultsBefore(TreeNode root, string rootStr, TreeNode expected, string expectedStr)
    {
        Console.Write("original: ");
        Console.WriteLine(rootStr);
        PrintBinaryTree(root);

        Console.Write("expected: ");
        Console.WriteLine(expectedStr);
        PrintBinaryTree(expected);
    }

    public static void PrintResultsAfter(TreeNode actual, string actualStr)
    {
        Console.Write("actual: ");
        Console.WriteLine(actualStr);
        PrintBinaryTree(actual);
    }
}