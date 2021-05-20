using System.Collections.Generic;
using static TreeUtils;

/*
public class Solution
{
    private List<int> list = new List<int>();

    public IList<int> Preorder(Node root)
    {
        if (root == null) return list;

        DFS(root);

        return list;
    }

    private void DFS(Node root)
    {
        if (root == null) return;

        list.Add(root.val);

        foreach (Node child in root.children)
            DFS(child);
    }
}
*/

public class Solution
{
    private List<int> list = new List<int>();

    public IList<int> Preorder(Node root)
    {
        if (root == null) return list;

        list.Add(root.val);

        foreach (Node child in root.children)
        {
            Preorder(child);
        }

        return list;
    }
}

/*
public class Solution
{
    private List<int> list = new List<int>();

    public IList<int> Preorder(Node root)
    {
        if (root == null) return list;

        list.Add(root.val);

        if (root.children != null)
        {
            foreach (Node child in root.children)
            {
                Preorder(child);
            }
        }

        return list;
    }
}
*/

/*
public class Solution
{
    public IList<int> Preorder(Node root)
    {
        var list = new List<int>();

        if (root == null)
            return list;

        var stack = new Stack<Node>();
        stack.Push(root);

        while (stack.Count != 0)
        {
            Node parent = stack.Pop();
            list.Add(parent.val);

            if (parent.children != null)
            {
                for (int i = parent.children.Count - 1; i >= 0; i--)
                {
                    Node child = parent.children[i];
                    stack.Push(child);
                }
            }
        }

        return list;
    }
}
*/

/*public class Solution
{
    public IList<int> Preorder(Node root)
    {
        var list = new List<int>();

        if (root == null)
            return list;

        var stack = new Stack<Node>();
        stack.Push(root);

        while (stack.Count != 0)
        {
            Node parent = stack.Pop();
            list.Add(parent.val);

            for (int i = parent.children.Count - 1; i >= 0; i--)
            {
                Node child = parent.children[i];
                stack.Push(child);
            }
        }

        return list;
    }
}*/