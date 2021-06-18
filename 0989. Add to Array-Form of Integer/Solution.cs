using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

/*public class Solution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var str = string.Concat(num);
        var x = BigInteger.Parse(str);

        return (x + k).ToString().Select(c => (int) char.GetNumericValue(c)).ToList();
    }
}*/

/*
public class Solution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var list = new List<int>();
        int i = num.Length - 1;

        while (i >= 0 || k > 0)
        {
            if (i >= 0)
                k += num[i];

            list.Add(k % 10);
            k /= 10;

            i--;
        }

        list.Reverse();

        return list;
    }
}
*/


/*public class Solution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var list = new List<int>();
        int pos = num.Length - 1;

        while (pos >= 0 || k > 0)
        {
            if (pos >= 0)
                k += num[pos];

            list.Insert(0, k % 10);
            k /= 10;

            pos--;
        }

        return list;
    }
}*/

public class Solution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        int pos = num.Length - 1;
        var carry = false;

        while (pos >= 0)
        {
            k = Math.DivRem(k, 10, out int rem);

            num[pos] += rem;

            if (carry)
            {
                num[pos]++;
                carry = false;
            }

            if (num[pos] > 9)
            {
                num[pos] %= 10;
                carry = true;
            }

            pos--;
        }

        if (k > 0)
        {
            var list = new List<int>();

            // handle part for k that is more than num
            // prepend for each digit read
            while (k > 0)
            {
                k = Math.DivRem(k, 10, out int rem);

                if (carry)
                {
                    rem += 1;
                    carry = false;
                }

                if (rem > 9)
                {
                    rem -= 10;
                    carry = true;
                }

                list.Insert(0, rem);
            }

            if (carry) 
                list.Insert(0, 1);

            list.AddRange(num);

            return list.ToArray();
        }

        if (carry)
        {
            var array2 = new int[num.Length + 1];
            Array.Copy(num, 0, array2, 1, num.Length);
            array2[0] = 1;

            return array2;
        }

        return num;
    }
}