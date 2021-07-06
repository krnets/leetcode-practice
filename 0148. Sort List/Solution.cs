using static ListUtils;

/*
public class Solution
{
    public ListNode SortList(ListNode head)
    {
        if (head?.next == null)
            return head;

        ListNode left = head;
        ListNode right = head.next;

        while (right != null && right.next != null)
        {
            left = left.next;
            right = right.next.next;
        }

        right = left.next;
        left.next = null;

        left = SortList(head);
        right = SortList(right);

        head = null;
        ListNode tail = null;

        while (left != null && right != null)
        {
            bool isLeft = left.val < right.val;
            var curr = isLeft ? left : right;

            if (head == null)
                head = curr;
            else tail.next = curr;

            tail = curr;

            if (isLeft)
                left = curr.next;
            else right = curr.next;
        }

        tail.next = left ?? right;

        return head;
    }
}
*/

public class Solution
{
    public ListNode SortList(ListNode head)
    {
        if (head?.next == null) return head;

        var mid = GetMiddle(head);
        var midNext = mid.next;
        mid.next = null;

        var left = SortList(head);
        var right = SortList(midNext);

        var merged = MergeLists(left, right);

        return merged;
    }

    private ListNode MergeLists(ListNode left, ListNode right)
    {
        var head = new ListNode();
        var tail = head;

        while (left != null && right != null)
        {
            if (left.val < right.val)
            {
                tail.next = left;
                left = left.next;
            }
            else
            {
                tail.next = right;
                right = right.next;
            }

            tail = tail.next;
        }

        tail.next = left ?? right;

        return head.next;
    }

    private ListNode GetMiddle(ListNode head)
    {
        var slow = head;
        var fast = head.next;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}