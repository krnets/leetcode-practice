using static TreeUtils;

/* public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        while (true)
        {
            if (root == null)
                return null;

            if (root.val > val)
            {
                root = root.left;
                continue;
            }

            if (root.val < val)
            {
                root = root.right;
                continue;
            }

            return root;
        }
    }
}*/


/*public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        return root == null ? null :
            root.val > val ? SearchBST(root.left, val) :
            root.val < val ? SearchBST(root.right, val) : root;
    }
}*/

/*public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        return root == null || root.val == val ? root :
            root.val > val ? SearchBST(root.left, val) : SearchBST(root.right, val);
    }
}*/

/*public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        return root == null || root.val == val ? root :
            root.val < val ? SearchBST(root.right, val) : SearchBST(root.left, val);
    }
}*/

/*public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        while (root != null)
        {
            if (root.val == val) return root;

            if (root.val < val)
            {
                root = root.right;
                continue;
            }

            if (root.val > val)
                root = root.left;
        }

        return null;
    }
}*/

public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        while (root != null)
        {
            if (root.val == val) return root;

            if (root.val < val)
            {
                root = root.right;
                continue;
            }

            root = root.left;
        }

        return null;
    }
}