using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public IList<string> SubdomainVisits(string[] cpdomains)

    {
        var visitCount = new Dictionary<string, int>();

        foreach (var cpDomain in cpdomains)
        {
            int i = cpDomain.IndexOf(' ');
            var str = cpDomain[(i + 1)..];
            int j = str.IndexOf('.');
            int n = int.Parse(cpDomain[..i]);
            visitCount[str] = visitCount.GetValueOrDefault(str, 0) + n;

            while (j != -1)
            {
                str = str[(j + 1)..];
                visitCount[str] = visitCount.GetValueOrDefault(str, 0) + n;
                j = str.IndexOf('.');
            }
        }

        return visitCount.Keys.Select(domain => $"{visitCount[domain]} {domain}").ToArray();
    }
}*/

public class Solution
{
    public IList<string> SubdomainVisits(string[] cpdomains)
    {
        var visitCount = new Dictionary<string, int>();

        foreach (var str in cpdomains)
        {
            int i = str.IndexOf(' ');
            int n = int.Parse(str[..i]);
            string domain = str[(i + 1)..];
            int j = domain.IndexOf('.');
            visitCount[domain] = visitCount.GetValueOrDefault(domain, 0) + n;

            while (j != -1)
            {
                domain = domain[(j + 1)..];
                visitCount[domain] = visitCount.GetValueOrDefault(domain, 0) + n;
                j = domain.IndexOf('.');
            }
        }

        var result = new List<string>();

        foreach (var domain in visitCount.Keys)
        {
            result.Add($"{visitCount[domain]} {domain}");
        }

        return result;
    }
}