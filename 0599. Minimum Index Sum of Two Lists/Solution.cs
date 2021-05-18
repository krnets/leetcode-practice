/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var intersect = list2.Intersect(list1).ToList();
        var map = new Dictionary<string, int>();

        for (int i = 0; i < list1.Length; i++)
            if (intersect.Contains(list1[i]))
                map[list1[i]] = i;


        for (int i = 0; i < list2.Length; i++)
        {
            if (intersect.Contains(list2[i]))
            {
                if (map.ContainsKey(list2[i]))
                    map[list2[i]] += i;
                else map[list2[i]] = i;
            }
        }

        int min = map.Values.Min();
        bool areAllSame = map.Values.All(x => x == min);

        return areAllSame ? intersect.ToArray() : new[] {map.First(p => p.Value == min).Key};
    }
}*/

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        int minSum = int.MaxValue;
        var result = new List<string>();
        var map = list1.Select((str, i) => new {str, i}).ToDictionary(o => o.str, o => o.i);

        for (int i = 0; i < list2.Length; i++)
        {
            var str = list2[i];

            if (map.ContainsKey(str))
            {
                int sum = map[str] + i;

                if (minSum == sum)
                    result.Add(str);
                else if (minSum > sum)
                {
                    result.Clear();
                    result.Add(str);
                    minSum = sum;
                }
            }
        }

        return result.ToArray();
    }
}