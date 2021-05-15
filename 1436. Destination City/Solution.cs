/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        var set = new HashSet<string>();

        foreach (var path in paths)
            set.Add(path[1]);

        foreach (var path in paths)
            set.Remove(path[0]);

        return set.SingleOrDefault();
    }
}*/

/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        var setFrom = new HashSet<string>();
        var setTo = new HashSet<string>();

        foreach (var path in paths)
        {
            setFrom.Add(path[0]);
            setTo.Add(path[1]);
        }

        setTo.ExceptWith(setFrom);

        return setTo.SingleOrDefault();
    }
}*/

/*using System.Collections.Generic;

public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        var setFrom = new HashSet<string>();
        var setTo = new HashSet<string>();

        foreach (var path in paths)
        {
            setFrom.Add(path[0]);
            setTo.Add(path[1]);
        }

        foreach (var dest in setTo)
            if (!setFrom.Contains(dest))
                return dest;

        return string.Empty;
    }
}*/

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        var setFrom = new HashSet<string>();
        var setTo = new HashSet<string>();

        foreach (var path in paths)
        {
            setFrom.Add(path[0]);
            setTo.Add(path[1]);
        }

        return setTo.FirstOrDefault(dest => !setFrom.Contains(dest));
    }
}