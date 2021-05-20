using static TreeUtils;

/*public class Solution
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root == null)
            return new TreeNode(val);

        if (root.val < val)
            root.right = InsertIntoBST(root.right, val);
        else if (root.val > val)
            root.left = InsertIntoBST(root.left, val);

        return root;
    }
}*/

public class Solution
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root == null)
            return new TreeNode(val);

        if (root.val < val)
            root.right = InsertIntoBST(root.right, val);
        else root.left = InsertIntoBST(root.left, val);

        return root;
    }
}