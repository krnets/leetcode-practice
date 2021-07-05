using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public int KthSmallest(TreeNode root, int k)
    {
        var list = new List<int>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                var currNode = queue.Dequeue();
                list.Add(currNode.val);

                if (currNode.left != null) queue.Enqueue(currNode.left);
                if (currNode.right != null) queue.Enqueue(currNode.right);
            }
        }

        return list.OrderBy(x => x).Skip(k - 1).First();
    }
}*/

public class Solution
{
    private List<int> list = new List<int>();

    public int KthSmallest(TreeNode root, int k)
    {
        InOrderTraverse(root);

        return list.ElementAt(k - 1);
    }

    private void InOrderTraverse(TreeNode node)
    {
        if (node == null) return;

        InOrderTraverse(node.left);
        list.Add(node.val);
        InOrderTraverse(node.right);
    }
}