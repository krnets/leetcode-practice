/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string ReformatDate(string date)
    {
        var months = new List<string>
            {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

        var array = date.Split();
        array[0] = $"{int.Parse(array[0][..^2]):d2}";
        array[1] = $"{(months.IndexOf(array[1]) + 1):d2}";

        return string.Join("-", array.Reverse());
    }
}*/

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private static List<string> months = new List<string>
        {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

    public string ReformatDate(string date)
    {
        var array = date.Split();
        array[0] = $"{int.Parse(array[0][..^2]):d2}";
        array[1] = $"{(months.IndexOf(array[1]) + 1):d2}";

        return string.Join("-", array.Reverse());
    }
}