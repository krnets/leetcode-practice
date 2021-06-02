using static ListUtils;

/*public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;

        while (fast?.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        return slow;
    }
}*/

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        int count = 0;
        var node = head;

        while (node != null)
        {
            count++;
            node = node.next;
        }

        int mid = count / 2;
        count = 0;
        node = head;

        while (count < mid)
        {
            node = node.next;
            count++;
        }

        return node;
    }
}