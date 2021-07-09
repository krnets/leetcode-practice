using System;
using System.Collections.Generic;
using System.Linq;

/*
public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        int n = matrix.Length;
        var list = new List<int>();

        for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            list.Add(matrix[i][j]);

        return list.OrderBy(x => x).ElementAt(k - 1);
    }
}
*/

/*public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        int n = matrix.Length;
        int smallest = 0;

        var comparer = new DuplicateKeyComparer<int>();
        var sortedList = new SortedList<int, (int, int)>(comparer);

        for (int i = 0; i < n; i++)
            sortedList.Add(matrix[i][0], (i, 0));

        while (k-- > 0)
        {
            smallest = sortedList.First().Key;
            int x = sortedList.First().Value.Item1;
            int y = sortedList.First().Value.Item2;

            sortedList.RemoveAt(0);

            if (y < (n - 1))
                sortedList.Add(matrix[x][y + 1], (x, y + 1));
        }

        return smallest;
    }

    public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
    {
        public int Compare(TKey x, TKey y)
        {
            if (x == null || y == null)
                return 1;

            int result = x.CompareTo(y);

            return result == 0 ? 1 : result;
        }
    }
}*/

/*public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        if (matrix.Length == 0) return 0;

        int n = matrix.Length;
        int ans = 0;
        var sortedSet = new SortedSet<(int, int, int)>();

        for (int i = 0; i < n; i++)
        {
            int firstElem = matrix[i][0];
            var t = (firstElem, i, 0);
            sortedSet.Add(t);
        }

        while (k > 0)
        {
            var tuple = sortedSet.Min;
            var (key, row, col) = tuple;
            ans = key;

            sortedSet.Remove(tuple);

            if (col < (n - 1))
            {
                int index = matrix[row][col + 1];
                var t = (index, row, col + 1);
                sortedSet.Add(t);
            }

            k--;
        }

        return ans;
    }
}*/

/*public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        return matrix.SelectMany(x => x).OrderBy(x => x).ElementAt(k - 1);
    }
}*/


/*
public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        var inputs = new List<(int, int)>();

        for (int i = 0; i < matrix.Length; i++)
            inputs.Add((0, i));

        var comparer = new IndicesComparer(matrix);
        var heap = new Heap<(int, int)>(inputs, comparer);
        int ans = 0;

        while (k > 0)
        {
            var curr = heap.ExtractTop();
            ans = matrix[curr.Item1][curr.Item2];

            if (curr.Item1 < matrix.Length - 1)
                heap.Add((curr.Item1 + 1, curr.Item2));

            k--;
        }

        return ans;
    }

    private class Heap<T>
    {
        private readonly IList<T> data;
        private readonly IComparer<T> _comparer;
        private int Count => data.Count;
        private T Top => data[0];

        public Heap(IList<T> inputs, IComparer<T> comparer = null)
        {
            _comparer = comparer ?? Comparer<T>.Default;
            data = inputs;

            for (int i = Count / 2; i >= 0; i--)
                SiftDown(i);
        }

        private void Swap(int i, int j)
        {
            (data[i], data[j]) = (data[j], data[i]);
        }

        private void SiftDown(int i)
        {
            while (2 * i + 1 < data.Count)
            {
                int left = 2 * i + 1;
                int right = 2 * i + 2;
                int j = left;

                if (right < data.Count && _comparer.Compare(data[right], data[left]) < 0)
                    j = right;

                if (_comparer.Compare(data[i], data[j]) <= 0)
                    break;

                Swap(i, j);
                i = j;
            }
        }

        private void SiftUp(int i)
        {
            while (_comparer.Compare(data[i], data[(i - 1) / 2]) < 0)
            {
                Swap(i, (i - 1) / 2);
                i = (i - 1) / 2;
            }
        }

        public T ExtractTop()
        {
            T top = Top;
            data[0] = data.Last();
            data.RemoveAt(Count - 1);
            SiftDown(0);
            return top;
        }

        public void Add(T value)
        {
            data.Add(value);
            SiftUp(Count - 1);
        }
    }

    private class IndicesComparer : IComparer<(int, int)>
    {
        private readonly int[][] matrix;
        public IndicesComparer(int[][] matrix) => this.matrix = matrix;

        public int Compare((int, int) x, (int, int) y)
        {
            return matrix[x.Item1][x.Item2].CompareTo(matrix[y.Item1][y.Item2]);
        }
    }
}
*/

public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        int n = matrix.Length;
        int size = Math.Min(n, k);
        int currentRank = 1;
        MinHeap minHeap = new MinHeap(size);

        for (int row = 0; row < size; row++)
            minHeap.Add(new MatrixInfo(matrix[row][0], row, 0));

        while (minHeap.Size() > 0)
        {
            if (currentRank == k)
                return minHeap.ExtractMin().Value;

            MatrixInfo min = minHeap.ExtractMin();

            if (min.Col + 1 < n)
            {
                var m = new MatrixInfo(matrix[min.Row][min.Col + 1], min.Row, min.Col + 1);

                minHeap.Add(m);
            }

            currentRank++;
        }

        return 0;
    }
}

class MatrixInfo
{
    public int Value { get; set; }
    public int Row { get; set; }
    public int Col { get; set; }

    public MatrixInfo(int val, int row, int col)
    {
        Value = val;
        Row = row;
        Col = col;
    }
}

class MinHeap
{
    int Capacity { get; }
    int CurrentSize { get; set; }
    MatrixInfo[] HeapArray { get; }

    public MinHeap(int capacity)
    {
        Capacity = capacity;
        CurrentSize = 0;
        HeapArray = new MatrixInfo[Capacity];
    }

    public int Size() => CurrentSize;
    int Parent(int idx) => (idx - 1) / 2;
    int Left(int idx) => (2 * idx) + 1;
    int Right(int idx) => (2 * idx) + 2;

    void Swap(int idx1, int idx2) =>
        (HeapArray[idx1], HeapArray[idx2]) = (HeapArray[idx2], HeapArray[idx1]);

    MatrixInfo GetMin() => CurrentSize == 0 ? throw new Exception("Empty heap") : HeapArray[0];

    public MatrixInfo ExtractMin()
    {
        if (CurrentSize == 0)
            throw new Exception("No element");

        var result = GetMin();

        //Replace root with the last element
        Swap(0, CurrentSize - 1);
        CurrentSize--;

        //Ensure Heap property: heapify down
        int idx = 0;
        int maxIndex = CurrentSize - 1;

        while (idx < maxIndex)
        {
            int smallest = idx;
            int left = Left(idx);

            //Compare with left, if it exists
            if (left <= maxIndex && HeapArray[left].Value < HeapArray[smallest].Value)
                smallest = left;

            int right = Right(idx);

            if (right <= maxIndex && HeapArray[right].Value < HeapArray[smallest].Value)
                smallest = right;

            //Already correct, no need to continue
            if (smallest == idx) break;

            //Re-arrange the item
            Swap(idx, smallest);
            idx = smallest;
        }

        return result;
    }

    public void Add(MatrixInfo item)
    {
        if (CurrentSize == Capacity)
            throw new Exception("Reach the max size");

        //Add the new element to the last
        HeapArray[CurrentSize] = item;
        CurrentSize++;

        //Ensure Heap property: heapify up
        int idx = CurrentSize - 1;

        while (idx > 0 && HeapArray[idx].Value < HeapArray[Parent(idx)].Value)
        {
            Swap(idx, Parent(idx));
            idx = Parent(idx);
        }
    }
}