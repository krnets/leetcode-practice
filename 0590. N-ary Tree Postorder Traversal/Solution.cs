using System.Collections.Generic;
using static TreeUtils;

/*
public class Solution
{
    private IList<int> list = new List<int>();

    public IList<int> Postorder(Node root)
    {
        if (root == null) return list;

        DFS(root);
        list.Add(root.val);

        return list;
    }

    private void DFS(Node root)
    {
        if (root == null) return;

        foreach (Node child in root.children)
        {
            DFS(child);
            list.Add(child.val);
        }
    }
}
*/

public class Solution
{
    private IList<int> list = new List<int>();

    public IList<int> Postorder(Node root)
    {
        if (root == null) return list;

        DFS(root);

        return list;
    }

    private void DFS(Node root)
    {
        if (root == null) return;

        foreach (Node child in root.children) 
            DFS(child);

        list.Add(root.val);
    }
}
