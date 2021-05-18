using System.Collections.Generic;

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

/*public class Solution
{
    public TreeNode IncreasingBST(TreeNode root)
    {
        var inOrderList = new List<int>();
        InOrderTraversal(root, inOrderList);

        return ConstructTree(inOrderList);
    }

    private static void InOrderTraversal(TreeNode root, List<int> inOrderList)
    {
        if (root == null) return;

        if (root.left != null)
            InOrderTraversal(root.left, inOrderList);

        inOrderList.Add(root.val);

        if (root.right != null)
            InOrderTraversal(root.right, inOrderList);
    }

    private static TreeNode ConstructTree(List<int> inOrderList)
    {
        if (inOrderList.Count == 0) return null;

        TreeNode root = new TreeNode(inOrderList[0]);
        TreeNode node = root;

        for (int i = 1; i < inOrderList.Count; i++)
        {
            node.right = new TreeNode(inOrderList[i]);
            node = node.right;
        }

        return root;
    }
}*/

public class Solution
{
    List<TreeNode> list = new List<TreeNode>();

    public TreeNode IncreasingBST(TreeNode root)
    {
        InOrder(root);

        for (int i = 0; i < list.Count - 1; i++)
        {
            list[i].left = null;
            list[i].right = list[i + 1];
        }

        list[^1].left = null;
        list[^1].right = null;

        return list[0];
    }

    private void InOrder(TreeNode node)
    {
        if (node == null) return;

        InOrder(node.left);
        list.Add(node);
        InOrder(node.right);
    }
}