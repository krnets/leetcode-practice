/*using System;
using static TreeUtils;

public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null) 
            return 0;

        int minLeft = MinDepth(root.left);
        int minRight = MinDepth(root.right);

        if (minLeft == 0)
            return 1 + minRight;

        if (minRight == 0)
            return 1 + minLeft;

        return 1 + Math.Min(minLeft, minRight);
    }
}*/

using System.Collections.Generic;
using static TreeUtils;

public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        int depth = 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int length = queue.Count;
            depth++;

            for (int i = 0; i < length; i++)
            {
                var node = queue.Dequeue();

                if (node.left == null && node.right == null)
                    return depth;

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }

        return depth;
    }
}