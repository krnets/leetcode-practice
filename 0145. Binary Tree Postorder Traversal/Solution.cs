using System.Collections.Generic;
using static TreeUtils;

/*public class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        PostOrder(root, list);

        return list;
    }

    private void PostOrder(TreeNode root, List<int> list)
    {
        if (root == null) return;
        PostOrder(root.left, list);
        PostOrder(root.right, list);
        list.Add(root.val);
    }
}*/

public class Solution
{
    private List<int> list = new List<int>();

    public IList<int> PostorderTraversal(TreeNode root)
    {
        if (root == null) return list;
        PostorderTraversal(root.left);
        PostorderTraversal(root.right);
        list.Add(root.val);

        return list;
    }
}