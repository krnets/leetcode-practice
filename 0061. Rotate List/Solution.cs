using static ListUtils;

/*

public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        int length = 0;
        var currNode = head;

        while (currNode != null)
        {
            currNode = currNode.next;
            length++;
        }

        int distToStart = length - (length > 0 ? k % length : 0);
        currNode = head;

        if (distToStart == length)
            return head;

        while (distToStart > 1)
        {
            currNode = currNode.next;
            distToStart--;
        }

        var end = currNode;
        var start = end.next;

        while (currNode.next != null)
        {
            currNode = currNode.next;
        }

        currNode.next = head;
        end.next = null;

        return start;
    }
}*/


public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null)
            return null;

        var currNode = head;
        int length = 1;

        while (currNode.next != null)
        {
            currNode = currNode.next;
            length++;
        }

        int distToStart = length - (length > 0 ? k % length : 0);

        if (distToStart == length)
            return head;

        currNode.next = head;
        currNode = head;

        while (distToStart > 1)
        {
            currNode = currNode.next;
            distToStart--;
        }

        var start = currNode.next;
        currNode.next = null;

        return start;
    }
}