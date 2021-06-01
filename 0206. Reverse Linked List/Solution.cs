using static ListUtils;

/*
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null, curr = null;

        while (head != null)
        {
            curr = new ListNode(head.val);
            curr.next = prev;
            prev = curr;

            head = head.next;
        }

        return curr;
    }
}*/

/*
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prevHead = null;

        while (head != null)
        {
            ListNode next = head.next;
            head.next = prevHead;
            prevHead = head;
            head = next;
        }

        return prevHead;
    }
}
*/

/*
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head?.next == null) return head;

        ListNode current = ReverseList(head.next);

        head.next.next = head;
        head.next = null;

        return current;
    }
}
*/

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;
        ListNode next;

        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}


/*public class Solution
{
    ListNode currNode;
    ListNode original;

    public ListNode ReverseList(ListNode head)
    {
        if (head == null)
            return null;

        original = head;

        Traverse(head.next, head);

        original.next = null;

        return currNode;
    }

    public void Traverse(ListNode node, ListNode prev)
    {
        if (node != null)
        {
            Traverse(node.next, node);

            node.next = prev;
        }
        else currNode = prev;
    }
}*/