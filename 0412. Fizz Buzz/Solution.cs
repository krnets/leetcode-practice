using System.Collections.Generic;

/*public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var list = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            if (i % 5 == 0)
            {
                list.Add(i % 3 == 0 ? "FizzBuzz" : "Buzz");
            }
            else if (i % 3 == 0)
            {
                list.Add("Fizz");
            }
            else list.Add($"{i}");
        }

        return list;
    }
}*/

/*public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var list = new List<string>();
        string fizz = "Fizz";
        string buzz = "Buzz";
        string fizzBuzz = fizz + buzz;

        for (int i = 1; i <= n; i++)
        {
            if (i % 5 == 0)
            {
                list.Add(i % 3 == 0 ? fizzBuzz : buzz);
            }
            else if (i % 3 == 0)
            {
                list.Add(fizz);
            }
            else list.Add($"{i}");
        }

        return list;
    }
}*/

public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var list = new List<string>();
        string fizz = "Fizz";
        string buzz = "Buzz";
        string fizzBuzz = fizz + buzz;

        for (int i = 1, f = 1, b = 1; i <= n; i++, f++, b++)
        {
            if (b == 5)
            {
                if (f == 3)
                {
                    list.Add(fizzBuzz);
                    f = 0;
                }
                else list.Add(buzz);

                b = 0;
            }
            else if (f == 3)
            {
                list.Add(fizz);
                f = 0;
            }
            else list.Add($"{i}");
        }

        return list;
    }
}