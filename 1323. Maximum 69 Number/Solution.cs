public class Solution
{
    public int Maximum69Number(int num)
    {
        char[] arr = num.ToString().ToCharArray();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '6')
            {
                arr[i] = '9';
                break;
            }
        }

        return int.Parse(new string(arr));
    }
}


/*
using System.Text;

public class Solution
{
    public int Maximum69Number(int num)
    {
        var sb = new StringBuilder(num.ToString());

        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == '6')
            {
                sb[i] = '9';
                break;
            }
        }

        return int.Parse(sb.ToString());
    }
}*/