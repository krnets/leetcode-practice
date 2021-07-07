using System.Collections.Generic;

/*public class Solution
{
    private int target;
    private HashSet<int> set = new HashSet<int>();

    public bool FindTarget(TreeNode root, int k)
    {
        target = k;

        return TargetExists(root);
    }

    private bool TargetExists(TreeNode root)
    {
        if (root == null)
            return false;

        if (set.Contains(target - root.val))
            return true;

        set.Add(root.val);

        return TargetExists(root.left) || TargetExists(root.right);
    }
}*/

public class Solution
{
    public bool FindTarget(TreeNode root, int k)
    {
        if (root == null)
            return k == 0;

        var set = new HashSet<int>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var currNode = queue.Dequeue();

            if (set.Contains(k - currNode.val))
                return true;

            set.Add(currNode.val);

            if (currNode.left != null) queue.Enqueue(currNode.left);
            if (currNode.right != null) queue.Enqueue(currNode.right);
        }

        return false;
    }
}