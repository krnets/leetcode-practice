using System.Text;

public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        var sb = new StringBuilder();

        while (columnNumber > 0)
        {
            columnNumber -= 1;

            sb.Insert(0, (char) ('A' + columnNumber % 26));

            columnNumber /= 26;
        }

        return sb.ToString();
    }
}