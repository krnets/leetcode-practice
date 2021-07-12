using System.Collections.Generic;

/*public class MyStack
{
    private Queue<int> queueMain;
    private Queue<int> queueAux;
    private int top;

    public MyStack()
    {
        queueMain = new Queue<int>();
        queueAux = new Queue<int>();
    }

    public bool Empty() => queueMain.Count == 0;

    public int Top() => top;

    public void Push(int x)
    {
        queueMain.Enqueue(x);
        top = x;
    }

    public int Pop()
    {
        while (queueMain.Count > 1)
        {
            top = queueMain.Dequeue();
            queueAux.Enqueue(top);
        }

        int item = queueMain.Dequeue();

        (queueMain, queueAux) = (queueAux, queueMain);

        return item;
    }
}*/


/*public class MyStack
{
    private Queue<int> queue = new Queue<int>();

    public bool Empty() => queue.Count == 0;
    public int Top() => queue.Peek();
    public int Pop() => queue.Dequeue();

    public void Push(int x)
    {
        int size = queue.Count;
        queue.Enqueue(x);

        while (size > 0)
        {
            queue.Enqueue(queue.Dequeue());
            size--;
        }
    }
}*/

public class MyStack
{
    private Queue<int> queue = new Queue<int>();

    public bool Empty() => queue.Count == 0;
    public int Top() => queue.Peek();
    public int Pop() => queue.Dequeue();

    public void Push(int x)
    {
        int size = queue.Count;
        queue.Enqueue(x);

        for (int i = 0; i < size; i++)
            queue.Enqueue(queue.Dequeue());
    }
}