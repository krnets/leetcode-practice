/*using System.Collections.Generic;

public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> validIpList = new List<string>();
        int[] octets = new int[4];

        RecurBuildOctets(validIpList, s, 0, octets, 0);

        return validIpList;
    }

    private void RecurBuildOctets(List<string> list, string s, int i, int[] octets, int octetId)
    {
        if (octetId == 4)
        {
            if (i == s.Length)
                list.Add($"{octets[0]}.{octets[1]}.{octets[2]}.{octets[3]}");

            return;
        }

        for (int len = 1; (len <= 3) && (i + len <= s.Length); len++)
        {
            string sub = s.Substring(i, len);
            int n = int.Parse(sub);

            if (n > 255 || len >= 2 && s[i] == '0')
                break;

            octets[octetId] = n;

            RecurBuildOctets(list, s, i + len, octets, octetId + 1);
        }
    }
}*/


using System.Collections.Generic;

public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> validIpList = new List<string>();

        string[] octets = new string[4];

        FindValidIPs(validIpList, s, 0, octets, 0);

        return validIpList;
    }

    private void FindValidIPs(List<string> list, string s, int i, string[] octets, int octetId)
    {
        if (octetId == 4)
        {
            if (i == s.Length)
                list.Add(string.Join('.', octets));

            return;
        }

        for (int len = 1; (len <= 3) && (i + len <= s.Length); len++)
        {
            string octet = s.Substring(i, len);

            if (int.Parse(octet) > 255 || len >= 2 && s[i] == '0')
                break;

            octets[octetId] = octet;

            FindValidIPs(list, s, i + len, octets, octetId + 1);
        }
    }
}