using System.Collections.Generic;

/*public class Solution
{
    private HashSet<int> set = new HashSet<int>();

    public int FindSecondMinimumValue(TreeNode root)
    {
        InOrderTraversal(root);

        return set.Count < 2 ? -1 : set.OrderBy(x => x).ElementAt(1);
    }

    private void InOrderTraversal(TreeNode node)
    {
        if (node == null) return;

        InOrderTraversal(node.left);
        set.Add(node.val);
        InOrderTraversal(node.right);
    }
}*/

/*public class Solution
{
    public int FindSecondMinimumValue(TreeNode root)
    {
        var set = new HashSet<int>();
        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var top = stack.Pop();
            set.Add(top.val);
            if (top.left != null) stack.Push(top.left);
            if (top.right != null) stack.Push(top.right);
        }

        return set.Count < 2 ? -1 : set.OrderBy(x => x).ElementAt(1);
    }
}*/

/*public class Solution
{
    public int FindSecondMinimumValue(TreeNode root)
    {
        var set = new SortedSet<int>();
        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var top = stack.Pop();
            set.Add(top.val);
            if (top.left != null) stack.Push(top.left);
            if (top.right != null) stack.Push(top.right);
        }

        return set.Count < 2 ? -1 : set.ElementAt(1);
    }
}*/

public class Solution
{
    public int FindSecondMinimumValue(TreeNode root)
    {
        if (root == null)
            return -1;

        int first = -1;
        int second = -1;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var currNode = queue.Dequeue();
            int val = currNode.val;

            if (val < first || first == -1)
            {
                (second, first) = (first, val);
            }
            else if (val != first && (val < second || second == -1))
            {
                second = val;
            }

            if (currNode.left != null) queue.Enqueue(currNode.left);
            if (currNode.right != null) queue.Enqueue(currNode.right);
        }

        return second;
    }
}