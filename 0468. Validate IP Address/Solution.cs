using System;

public class Solution
{
    public string ValidIPAddress(string IP)
    {
        return IsValidIPv4(IP) ? "IPv4" : IsValidIPV6(IP) ? "IPv6" : "Neither";
    }

    private bool IsValidIPv4(string ip)
    {
        var split = ip.Split(".");

        foreach (string octet in split)
        {
            if (octet.Length == 0)
                return false;

            if (octet.Length > 1 && octet[0] == '0')
                return false;

            if (int.TryParse(octet, out int x))
            {
                if (x < 0 || x > 255)
                    return false;
            }
            else return false;
        }

        return split.Length == 4;
    }

    private bool IsValidIPV6(string ip)
    {
        var split = ip.Split(":");

        foreach (string s in split)
        {
            if (s.Length > 4) return false;

            try
            {
                Convert.ToInt32(s, 16);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        return split.Length == 8;
    }
}