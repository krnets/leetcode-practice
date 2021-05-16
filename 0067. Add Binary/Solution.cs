/*using System.Collections.Generic;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var list = new LinkedList<int>();
        int aEnd = a.Length - 1;
        int bEnd = b.Length - 1;
        int carry = 0;

        while (aEnd >= 0 || bEnd >= 0)
        {
            int sum = carry;

            if (aEnd >= 0)
            {
                sum += a[aEnd] - '0';
                aEnd--;
            }

            if (bEnd >= 0)
            {
                sum += b[bEnd] - '0';
                bEnd--;
            }

            list.AddFirst(sum % 2);
            carry = sum / 2;
        }

        if (carry == 1)
            list.AddFirst(carry);

        return string.Concat(list);
    }
}*/

/*using System.Collections.Generic;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var stack = new Stack<int>();
        int aEnd = a.Length - 1;
        int bEnd = b.Length - 1;
        int carry = 0;

        while (aEnd >= 0 || bEnd >= 0)
        {
            int sum = carry;

            if (aEnd >= 0)
            {
                sum += a[aEnd] - '0';
                aEnd--;
            }

            if (bEnd >= 0)
            {
                sum += b[bEnd] - '0';
                bEnd--;
            }

            stack.Push(sum % 2);
            carry = sum / 2;
        }

        if (carry == 1)
            stack.Push(carry);

        return string.Concat(stack);
    }
}*/

/*public class Solution
{
    public string AddBinary(string a, string b)
    {
        var stack = new Stack<char>();
        int maxLen = Math.Max(a.Length, b.Length);
        bool carry = false;

        for (int i = 0; i < maxLen; i++)
        {
            char first = '0';
            char second = '0';

            if (a.Length - 1 - i >= 0)
                first = a[a.Length - 1 - i];

            if (b.Length - 1 - i >= 0)
                second = b[b.Length - 1 - i];

            if (first == '0' && second == '0')
            {
                stack.Push(carry ? '1' : '0');
                carry = false;
            }
            else if (first == '1' && second == '1')
            {
                stack.Push(carry ? '1' : '0');
                carry = true;
            }
            else
            {
                stack.Push(carry ? '0' : '1');
            }
        }

        if (carry) stack.Push('1');

        return string.Concat(stack);
    }
}*/

/*public class Solution
{
    public string AddBinary(string a, string b)
    {
        var stack = new Stack<char>();
        int aLen = a.Length - 1;
        int bLen = b.Length - 1;
        int maxLen = Math.Max(a.Length, b.Length);
        bool carry = false;

        for (int i = 0; i < maxLen; i++)
        {
            char first = '0';
            char second = '0';

            if (aLen - i >= 0)
                first = a[aLen - i];

            if (bLen - i >= 0)
                second = b[bLen - i];

            if (first == '0' && second == '0')
            {
                stack.Push(carry ? '1' : '0');
                carry = false;
            }
            else if (first == '1' && second == '1')
            {
                stack.Push(carry ? '1' : '0');
                carry = true;
            }
            else
            {
                stack.Push(carry ? '0' : '1');
            }
        }

        if (carry)
            stack.Push('1');

        return string.Concat(stack);
    }
}*/

/*using System;
using System.Collections.Generic;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var stack = new Stack<char>();
        int aLen = a.Length - 1;
        int bLen = b.Length - 1;
        int maxLen = Math.Max(a.Length, b.Length);
        bool carry = false;

        for (int i = 0; i < maxLen; i++)
        {
            var (first, second) = ('0', '0');
            if (aLen - i >= 0) first = a[aLen - i];
            if (bLen - i >= 0) second = b[bLen - i];

            switch (first)
            {
                case '0' when second is '0':
                    stack.Push(carry ? '1' : '0');
                    carry = false;
                    break;
                case '1' when second is '1':
                    stack.Push(carry ? '1' : '0');
                    carry = true;
                    break;
                default:
                    stack.Push(carry ? '0' : '1');
                    break;
            }
        }

        if (carry)
            stack.Push('1');

        return string.Concat(stack);
    }
}*/


/*public class Solution
{
    public string AddBinary(string a, string b)
    {
        var stack = new Stack<char>();
        int aLen = a.Length - 1;
        int bLen = b.Length - 1;
        int maxLen = Math.Max(a.Length, b.Length);
        bool carry = false;

        for (int i = 0; i < maxLen; i++)
        {
            var (first, second) = ('0', '0');
            if (aLen - i >= 0) first = a[aLen - i];
            if (bLen - i >= 0) second = b[bLen - i];

            if (first == '0' && second == '0')
            {
                stack.Push(carry ? '1' : '0');
                carry = false;
            }
            else if (first == '1' && second == '1')
            {
                stack.Push(carry ? '1' : '0');
                carry = true;
            }
            else
            {
                stack.Push(carry ? '0' : '1');
            }
        }

        if (carry)
        {
            stack.Push('1');
        }

        return string.Concat(stack);
    }
}*/

using System;
using System.Text;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var sb = new StringBuilder();
        int aLen = a.Length - 1;
        int bLen = b.Length - 1;
        int maxLen = Math.Max(a.Length, b.Length);
        bool carry = false;

        for (int i = 0; i < maxLen; i++)
        {
            var (first, second) = ('0', '0');
            if (aLen - i >= 0) first = a[aLen - i];
            if (bLen - i >= 0) second = b[bLen - i];

            if (first == '0' && second == '0')
            {
                sb.Insert(0, carry ? '1' : '0');
                carry = false;
            }
            else if (first == '1' && second == '1')
            {
                sb.Insert(0, carry ? '1' : '0');
                carry = true;
            }
            else
            {
                sb.Insert(0, carry ? '0' : '1');
            }
        }

        if (carry)
        {
            sb.Insert(0, '1');
        }

        return string.Concat(sb);
    }
}