using System.Collections.Generic;
using System.Data;

/*public class MyHashSet
{
    private Dictionary<int, int> set = new Dictionary<int, int>();

    public void Add(int key)
    {
        if (!set.ContainsKey(key))
            set.Add(key, key);
    }

    public void Remove(int key)
    {
        set.Remove(key);
    }

    public bool Contains(int key)
    {
        return set.ContainsKey(key);
    }
}*/

public class MyHashSet
{
    private int _primeKey = 991;
    private List<int>[] _buckets;

    public MyHashSet() => _buckets = new List<int>[_primeKey];

    private int GetHash(int key) => key % _primeKey;

    public void Add(int key)
    {
        var index = GetHash(key);

        _buckets[index] ??= new List<int> {key};

        if (!_buckets[index].Contains(key))
            _buckets[index].Add(key);
    }

    public void Remove(int key)
    {
        int index = GetHash(key);

        if (_buckets[index] == null)
            return;

        _buckets[index].Remove(key);
    }

    public bool Contains(int key)
    {
        int index = GetHash(key);

        if (_buckets[index] == null)
            return false;

        return _buckets[index].Contains(key);
    }
}