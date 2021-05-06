public class Solution
{
    private int res;

    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root == null)
            return res;

        if (root.val < low)
        {
            RangeSumBST(root.right, low, high);
        }

        else if (root.val > high)
        {
            RangeSumBST(root.left, low, high);
        }
        else
        {
            res += root.val;
            RangeSumBST(root.left, low, high);
            RangeSumBST(root.right, low, high);
        }

        return res;
    }
}