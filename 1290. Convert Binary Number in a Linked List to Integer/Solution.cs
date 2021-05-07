using System;
using System.Text;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

/*public class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        var sb = new StringBuilder();

        while (head != null)
        {
            sb.Append(head.val);
            head = head.next;
        }

        return Convert.ToInt32(sb.ToString(), 2);
    }
}*/
/*public class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        int ans = 0;

        while (head != null)
        {
            ans <<= 1;
            ans += head.val;
            head = head.next;
        }

        return ans;
    }
}*/

public class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        int ans = 0;

        while (head != null)
        {
            ans *= 2;
            ans += head.val;
            head = head.next;
        }

        return ans;
    }
}