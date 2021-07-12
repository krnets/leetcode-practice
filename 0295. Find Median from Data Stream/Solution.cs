/*
using System;

public class MedianFinder
{
    private readonly MaxHeap small;
    private readonly MinHeap large;

    public MedianFinder()
    {
        small = new MaxHeap(10);
        large = new MinHeap(10);
    }

    public void AddNum(int num)
    {
        large.Insert(num);
        small.Insert(large.DeleteMin());

        if (small.Size() > large.Size())
            large.Insert(small.DeleteMax());
    }

    public double FindMedian()
    {
        if (large.Size() > small.Size())
            return large.Top();

        return (small.Top() + large.Top()) / 2.0;
    }

    public class MinHeap : PriorityQueue
    {
        public MinHeap() : base(10) { }

        public MinHeap(int initCapacity) : base(initCapacity) { }

        public int DeleteMin() => Delete();

        protected override void Sink(int k)
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && pq[j] > pq[j + 1]) j++;
                if (pq[k] <= pq[j]) break;
                Swap(k, j);
                k = j;
            }
        }

        protected override void Swim(int k)
        {
            while (k > 1 && pq[k / 2] > pq[k])
            {
                Swap(k / 2, k);
                k /= 2;
            }
        }
    }

    public class MaxHeap : PriorityQueue
    {
        public MaxHeap() : base(10) { }

        public MaxHeap(int initCapacity) : base(initCapacity) { }

        public int DeleteMax() => Delete();

        protected override void Sink(int k)
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && pq[j] < pq[j + 1]) j++;
                if (pq[k] >= pq[j]) break;
                Swap(k, j);
                k = j;
            }
        }

        protected override void Swim(int k)
        {
            while (k > 1 && pq[k / 2] < pq[k])
            {
                Swap(k / 2, k);
                k /= 2;
            }
        }
    }

    public abstract class PriorityQueue
    {
        protected int N;
        protected int[] pq;

        protected PriorityQueue() : this(1) { }

        protected PriorityQueue(int initCapacity)
        {
            N = 0;
            pq = new int[initCapacity + 1];
        }

        public int Size() => N;
        public bool IsEmpty() => Size == 0;
        public int First() => IsEmpty() ? throw new ArgumentOutOfRangeException() : pq[1];
        protected abstract void Sink(int k);
        protected abstract void Swim(int k);

        private void Resize(int newCapacity)
        {
            var temp = new int[newCapacity + 1];
            Array.Copy(pq, 1, temp, 1, Size);
            pq = temp;
        }

        public void Enqueue(int x)
        {
            if (Size >= pq.Length - 1)
                Resize(pq.Length * 2);

            pq[++Size] = x;
            CascadeUp(Size);
        }

        protected void Swap(int index1, int index2)
        {
            (pq[index1], pq[index2]) = (pq[index2], pq[index1]);
        }

        public int Dequeue()
        {
            int item = pq[1];

            Swap(1, N--);
            CascadeDown(1);
            pq[Size + 1] = 0;

            if (Size > 0 && Size == (pq.Length - 1) / 4)
                Resize(pq.Length / 2);

            return item;
        }
    }
}
*/

using System;

public class MedianFinder
{
    private readonly MaxHeap small;
    private readonly MinHeap large;

    public MedianFinder()
    {
        small = new MaxHeap(10);
        large = new MinHeap(10);
    }

    public void AddNum(int num)
    {
        large.Enqueue(num);
        small.Enqueue(large.Dequeue());

        if (small.Size > large.Size)
            large.Enqueue(small.Dequeue());
    }

    public double FindMedian()
    {
        if (small.Size < large.Size)
            return large.First();

        return (small.First() + large.First()) / 2.0;
    }

    public class MinHeap : PriorityQueue
    {
        public MinHeap() : base(10)
        {
        }

        public MinHeap(int initCapacity) : base(initCapacity)
        {
        }

        protected override void CascadeDown(int k)
        {
            while (2 * k <= Size)
            {
                int j = 2 * k;
                if (j < Size && pq[j] > pq[j + 1]) j++;
                if (pq[k] <= pq[j]) break;
                Swap(k, j);
                k = j;
            }
        }

        protected override void CascadeUp(int k)
        {
            while (k > 1 && pq[k / 2] > pq[k])
            {
                Swap(k / 2, k);
                k /= 2;
            }
        }
    }

    public class MaxHeap : PriorityQueue
    {
        public MaxHeap() : base(10)
        {
        }

        public MaxHeap(int initCapacity) : base(initCapacity)
        {
        }

        protected override void CascadeDown(int k)
        {
            while (2 * k <= Size)
            {
                int j = 2 * k;
                if (j < Size && pq[j] < pq[j + 1]) j++;
                if (pq[k] >= pq[j]) break;
                Swap(k, j);
                k = j;
            }
        }

        protected override void CascadeUp(int k)
        {
            while (k > 1 && pq[k / 2] < pq[k])
            {
                Swap(k / 2, k);
                k /= 2;
            }
        }
    }

    public abstract class PriorityQueue
    {
        protected int[] pq;
        public int Size { get; private set; }

        protected PriorityQueue() : this(1)
        {
        }

        protected PriorityQueue(int initCapacity)
        {
            Size = 0;
            pq = new int[initCapacity + 1];
        }

        public int First() => Size == 0 ? throw new ArgumentOutOfRangeException() : pq[1];
        protected abstract void CascadeUp(int k);
        protected abstract void CascadeDown(int k);

        private void Resize(int newCapacity)
        {
            var newArray = new int[newCapacity + 1];
            Array.Copy(pq, 1, newArray, 1, Size);
            pq = newArray;
        }

        public void Enqueue(int item)
        {
            if (Size >= pq.Length - 1)
                Resize(pq.Length * 2);

            pq[++Size] = item;
            CascadeUp(Size);
        }

        protected void Swap(int index1, int index2)
        {
            (pq[index1], pq[index2]) = (pq[index2], pq[index1]);
        }

        public int Dequeue()
        {
            int item = pq[1];

            Swap(1, Size--);
            CascadeDown(1);
            pq[Size + 1] = 0;

            if (Size > 0 && Size == (pq.Length - 1) / 4)
                Resize(pq.Length / 2);

            return item;
        }
    }
}