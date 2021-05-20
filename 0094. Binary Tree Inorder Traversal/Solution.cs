using System.Collections;
using System.Collections.Generic;
using static TreeUtils;

/*public class Solution
{
    private IList<int> list = new List<int>();

    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null) return list;

        InorderTraversal(root.left);
        list.Add(root.val);
        InorderTraversal(root.right);

        return list;
    }
}*/

/*public class Solution
{
    private IList<int> list = new List<int>();

    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null) return list;

        if (root.left != null)
            InorderTraversal(root.left);

        list.Add(root.val);

        if (root.right != null)
            InorderTraversal(root.right);

        return list;
    }
}*/

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> list = new List<int>();
        var stack = new Stack<TreeNode>();

        while (root != null || stack.Count != 0)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            var node = stack.Pop();
            list.Add(node.val);
            root = node.right;
        }

        return list;
    }
}