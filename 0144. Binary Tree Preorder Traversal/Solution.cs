using System.Collections.Generic;
using static TreeUtils;

/*public class Solution
{
    private IList<int> list = new List<int>();

    public IList<int> PreorderTraversal(TreeNode root)
    {
        if (root == null) return list;

        list.Add(root.val);
        if (root.left != null) PreorderTraversal(root.left);
        if (root.right != null) PreorderTraversal(root.right);

        return list;
    }
}*/

public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var list = new List<int>();

        if (root == null)
            return list;

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count != 0)
        {
            var node = stack.Pop();
            list.Add(node.val);

            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
        }

        return list;
    }
}