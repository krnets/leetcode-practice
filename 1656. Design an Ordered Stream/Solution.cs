using System.Collections.Generic;

public class OrderedStream
{
    private int index;
    private readonly string[] values;

    public OrderedStream(int n)
    {
        index = 0;
        values = new string[n];
    }

    public IList<string> Insert(int idKey, string value)
    {
        values[idKey - 1] = value;
        var list = new List<string>();

        while (index < values.Length && values[index] != null)
            list.Add(values[index++]);

        return list;
    }
}