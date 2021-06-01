using static ListUtils;

/*

public class Solution
{
    ListNode currNode;

    public bool IsPalindrome(ListNode head)
    {
        currNode = head;

        return RecursiveCheck(head);
    }

    public bool RecursiveCheck(ListNode node)
    {
        if (node == null) 
            return true;

        bool ans = RecursiveCheck(node.next);
        bool isEqual = (currNode.val == node.val);

        currNode = currNode.next;

        return ans && isEqual;
    }
}*/

public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode firstHalfEnd = endOfFirstHalf(head);
        ListNode secondHalfStart = Reverse(firstHalfEnd.next);

        ListNode p1 = head;
        ListNode p2 = secondHalfStart;

        while (p2 != null)
        {
            if (p1.val != p2.val) return false;
            p1 = p1.next;
            p2 = p2.next;
        }

        return true;
    }

    private ListNode Reverse(ListNode head)
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

    private ListNode endOfFirstHalf(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;

        while (fast.next?.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        return slow;
    }
}