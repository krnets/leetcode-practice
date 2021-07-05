using System.Collections.Generic;

/*public class Solution
{
    private IList<IList<int>> list = new List<IList<int>>();

    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        Traverse(root, 0);
        return list;
    }

    private void Traverse(TreeNode currNode, int level)
    {
        if (currNode == null) return;

        if (list.Count <= level)
            list.Add(new List<int> {currNode.val});
        else
            list[level].Add(currNode.val);

        Traverse(currNode.left, level + 1);
        Traverse(currNode.right, level + 1);
    }
}*/

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var list = new List<IList<int>>();

        if (root == null)
            return list;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int length = queue.Count;
            var subList = new List<int>();

            for (int i = 0; i < length; i++)
            {
                var currNode = queue.Dequeue();
                subList.Add(currNode.val);

                if (currNode.left != null) queue.Enqueue(currNode.left);
                if (currNode.right != null) queue.Enqueue(currNode.right);
            }

            list.Add(subList);
        }

        return list;
    }
}