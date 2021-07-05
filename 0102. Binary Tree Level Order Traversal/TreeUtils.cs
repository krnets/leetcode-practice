using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TreeUtils
{
    public static TreeNode ConstructBinaryTree(List<int?> list)
    {
        if (list == null || list.Count == 0)
            return null;

        TreeNode root = new TreeNode((int) list.First());
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        for (int i = 1; i < list.Count; i++)
        {
            var currNode = queue.Dequeue();

            if (list.ElementAt(i) != null)
            {
                currNode.left = new TreeNode((int) list.ElementAt(i));
                queue.Enqueue(currNode.left);
            }

            if (++i < list.Count && list.ElementAt(i) != null)
            {
                currNode.right = new TreeNode((int) list.ElementAt(i));
                queue.Enqueue(currNode.right);
            }
        }

        return root;
    }

    public static string BFSLevelOrderString(TreeNode root)
    {
        // if (root == null)
        //     return string.Empty;

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
        if (list.Count == 0 || list.All(x => x == null))
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
                if (list.ElementAt(j) == null)
                {
                    Console.Write(new string(' ', edgeLines + edgeLines + i + 1));
                    continue;
                }

                Console.Write(list.ElementAt(j).left == null ? new string(' ', 1) : "/");
                Console.Write(new string(' ', i + i - 1));
                Console.Write(list.ElementAt(j).right == null ? new string(' ', 1) : "\\");
                Console.Write(new string(' ', edgeLines + edgeLines - i));
            }

            Console.WriteLine();
        }

        PrintNodeInternal(newNodes, level + 1, maxLevel);
    }
}