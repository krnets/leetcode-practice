using System;
using System.Collections.Generic;

/*public class Solution
{
    public int DeepestLeavesSum(TreeNode root)
    {
        int levelSum = 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            levelSum = 0;
            int length = queue.Count;

            for (int i = 0; i < length; i++)
            {
                var currNode = queue.Dequeue();
                levelSum += currNode.val;

                if (currNode.left != null) queue.Enqueue(currNode.left);
                if (currNode.right != null) queue.Enqueue(currNode.right);
            }
        }

        return levelSum;
    }
}*/


public class Solution
{
    private static int _maxDepth;

    private int Depth(TreeNode root)
    {
        return root == null ? 0 : 1 + Math.Max(Depth(root.left), Depth(root.right));
    }

    public int DeepestLeavesSum(TreeNode root)
    {
        _maxDepth = Depth(root);

        return RecurHelper(root, 1);
    }

    private static int RecurHelper(TreeNode node, int curDepth)
    {
        if (node == null) return 0;

        if (curDepth == _maxDepth) return node.val;

        return RecurHelper(node.left, 1 + curDepth) + RecurHelper(node.right, 1 + curDepth);
    }
}