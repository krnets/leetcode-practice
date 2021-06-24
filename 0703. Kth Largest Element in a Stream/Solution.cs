using System.Collections.Generic;
using System.Linq;

/*public class KthLargest
{
    private SortedSet<(int x, int i)> Sorted;
    private int K, Index;

    public KthLargest(int k, int[] nums)
    {
        K = k;
        Index = nums.Length;

        Sorted = new SortedSet<(int x, int i)>
        (nums
                .Select((x, i) =>
                    (x, i)), Comparer<(int x, int i)>
                .Create((a, b) =>
                    a.x == b.x ? a.i.CompareTo(b.i) : b.x.CompareTo(a.x))
        );

        while (Sorted.Count > K)
        {
            Sorted.Remove(Sorted.Max);
        }
    }

    public int Add(int val)
    {
        Sorted.Add((val, Index++));

        while (Sorted.Count > K)
        {
            Sorted.Remove(Sorted.Max);
        }

        return Sorted.Max.x;
    }
}*/

/*public class KthLargest
{
    private SortedList<int, int> pq = new SortedList<int, int>();
    private int K;
    private int size;

    public KthLargest(int k, int[] nums)
    {
        K = k;

        foreach (int x in nums) Add(x);
    }

    public int Add(int val)
    {
        if (size < K || val > pq.First().Key)
        {
            if (pq.ContainsKey(val))
                pq[val]++;
            else pq.Add(val, 1);

            size++;
        }

        if (size > K)
        {
            var x = pq.First().Key;

            if (pq.First().Value > 1)
                pq[x]--;
            else pq.Remove(x);

            size--;
        }

        return pq.First().Key;
    }
}*/

public class KthLargest
{
    private int K;
    private List<int> list = new List<int>();

    public KthLargest(int k, int[] nums)
    {
        K = k;

        foreach (int val in nums)
            Insert(val);
    }

    public void Insert(int val)
    {
        int pos = list.BinarySearch(val);

        if (pos < 0)
            pos = ~pos;

        list.Insert(pos, val);
    }

    public int Add(int val)
    {
        Insert(val);

        return list[^K];
    }
}