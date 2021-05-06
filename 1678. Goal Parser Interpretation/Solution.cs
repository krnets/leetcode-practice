/*using System.Text;

public class Solution
{
    public string Interpret(string command)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == 'G')
                sb.Append(command[i]);
            else if (command.Substring(i, 2) == "()")
            {
                sb.Append("o");
                i++;
            }
            else if (command.Substring(i, 4) == "(al)")
            {
                sb.Append("al");
                i += 3;
            }
        }

        return sb.ToString();
    }
}*/

/*using System.Text;

public class Solution
{
    public string Interpret(string command)
    {
        var sb = new StringBuilder();
        int i = 0;

        while (i < command.Length)
        {
            if (command[i] == 'G')
            {
                sb.Append(command[i]);
                i++;
            }
            else if (command.Substring(i, 2) == "()")
            {
                sb.Append("o");
                i += 2;
            }
            else if (command.Substring(i, 4) == "(al)")
            {
                sb.Append("al");
                i += 4;
            }
        }

        return sb.ToString();
    }
}*/

public class Solution
{
    public string Interpret(string command)
    {
        return command.Replace("()", "o").Replace("(al)", "al");
    }
}