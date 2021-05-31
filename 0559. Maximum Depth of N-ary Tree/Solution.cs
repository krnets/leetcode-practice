/*using System.Collections.Generic;
using System.Linq;
using static TreeUtils;

public class Solution
{
    public int MaxDepth(Node root)
    {
        if (root == null) return 0;

        var allPaths = new List<List<int>>();
        var currentPath = new List<int>();

        DFS(root, currentPath, allPaths);

        return allPaths.Max(path => path.Count);
    }

    private void DFS(Node root, List<int> currentPath, List<List<int>> allPaths)
    {
        if (root == null)
            allPaths.Add(currentPath);

        if (root.children == null || root.children.Count == 0)
        {
            currentPath.Add(root.val);
            allPaths.Add(new List<int>(currentPath));
        }

        currentPath.Add(root.val);

        foreach (var node in root.children)
            DFS(node, new List<int>(currentPath), allPaths);
    }
}*/

/*using System.Collections.Generic;
using static TreeUtils;

public class Solution
{
    public int MaxDepth(Node root)
    {
        if (root == null) return 0;

        var queue = new Queue<Node>();
        queue.Enqueue(root);
        int depth = 0;

        while (queue.Count > 0)
        {
            int length = queue.Count;

            for (int i = 0; i < length; i++)
            {
                var current = queue.Dequeue();

                foreach (var node in current.children)
                {
                    queue.Enqueue(node);
                }
            }

            depth++;
        }

        return depth;
    }
}*/

using System;
using static TreeUtils;

public class Solution
{
    public int MaxDepth(Node root)
    {
        if (root == null) return 0;

        int depth = 0;

        foreach (Node node in root.children)
        {
            depth = Math.Max(depth, MaxDepth(node));
        }

        return 1 + depth;
    }
}