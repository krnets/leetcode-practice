using System;
using System.Collections.Generic;
using static TreeUtils;

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        int depth = 1;

        var stack = new Queue<TreeNode>();
        var treeLevels = new Queue<int>();

        stack.Enqueue(root);
        treeLevels.Enqueue(1);

        while (stack.Count > 0)
        {
            var node = stack.Dequeue();
            var currentLevel = treeLevels.Dequeue();

            if (node == null)
                continue;

            depth = Math.Max(depth, currentLevel);

            stack.Enqueue(node.left);
            treeLevels.Enqueue(depth + 1);

            stack.Enqueue(node.right);
            treeLevels.Enqueue(depth + 1);
        }

        return depth;
    }
}

/*public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}*/