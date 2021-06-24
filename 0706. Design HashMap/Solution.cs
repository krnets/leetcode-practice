// 100 runtime
/*public class MyHashMap
{
    class ListNode
    {
        public int Key;
        public int Val;
        public ListNode next;

        public ListNode(int key, int val)
        {
            Key = key;
            Val = val;
        }
    }

    private const int _size = 10_000;
    private readonly ListNode[] _nodes = new ListNode[_size];
    private int GetHash(int key) => key.GetHashCode() % _nodes.Length;

    public void Put(int key, int value)
    {
        int index = GetHash(key);

        _nodes[index] ??= new ListNode(-1, -1);

        var prev = find(_nodes[index], key);

        if (prev.next == null)
            prev.next = new ListNode(key, value);
        else prev.next.Val = value;
    }

    public int Get(int key)
    {
        int index = GetHash(key);

        if (_nodes[index] == null)
            return -1;

        var node = find(_nodes[index], key);

        return node.next?.Val ?? -1;
    }

    public void Remove(int key)
    {
        int index = GetHash(key);

        if (_nodes[index] == null) return;

        var prev = find(_nodes[index], key);

        if (prev.next == null)
            return;

        prev.next = prev.next.next;
    }

    private ListNode find(ListNode bucket, int key)
    {
        ListNode node = bucket;
        ListNode prev = null;

        while (node != null && node.Key != key)
        {
            prev = node;
            node = node.next;
        }

        return prev;
    }
}*/


// 100 memory
public class MyHashMap
{
    private int[] map = new int [10_000_000];

    public void Put(int key, int value) => map[key] = value + 1;
    public int Get(int key) => map[key] - 1;
    public void Remove(int key) => map[key] = 0;
}