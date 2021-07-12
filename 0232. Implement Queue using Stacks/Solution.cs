/*using System.Collections.Generic;

public class MyQueue
{
    private readonly Stack<int> queueMain;
    private readonly Stack<int> queueAux;

    public MyQueue()
    {
        queueMain = new Stack<int>();
        queueAux = new Stack<int>();
    }

    public bool Empty() => queueMain.Count == 0;

    public void Push(int x) => queueMain.Push(x);

    public int Pop()
    {
        while (queueMain.Count > 0)
        {
            queueAux.Push(queueMain.Pop());
        }

        queueAux.TryPop(out int item);

        while (queueAux.Count > 0)
        {
            queueMain.Push(queueAux.Pop());
        }

        return item;
    }

    public int Peek()
    {
        while (queueMain.Count > 0)
        {
            queueAux.Push(queueMain.Pop());
        }

        queueAux.TryPeek(out int item);

        while (queueAux.Count > 0)
        {
            queueMain.Push(queueAux.Pop());
        }

        return item;
    }
}*/

using System.Collections.Generic;

public class MyQueue
{
    private readonly Stack<int> queueMain;
    private readonly Stack<int> queueAux;

    public MyQueue()
    {
        queueMain = new Stack<int>();
        queueAux = new Stack<int>();
    }

    public bool Empty() => queueMain.Count == 0;

    public void Push(int x) => queueMain.Push(x);

    public int Pop()
    {
        MoveItemsToAuxQueue();
        queueMain.TryPop(out int item);
        MoveItemsBackToMainQueue();

        return item;
    }

    public int Peek()
    {
        MoveItemsToAuxQueue();
        queueMain.TryPeek(out int item);
        MoveItemsBackToMainQueue();

        return item;
    }

    private void MoveItemsToAuxQueue()
    {
        while (queueMain.Count > 1)
            queueAux.Push(queueMain.Pop());
    }

    private void MoveItemsBackToMainQueue()
    {
        while (queueAux.Count > 0)
            queueMain.Push(queueAux.Pop());
    }
}