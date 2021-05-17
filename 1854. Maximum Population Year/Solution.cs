/*
using System.Linq;

public class Solution
{
    public int MaximumPopulation(int[][] logs)
    {
        var yearsMap = logs
            .SelectMany(lifeSpan => Enumerable.Range(lifeSpan[0], lifeSpan[1] - lifeSpan[0]))
            .OrderBy(year => year)
            .GroupBy(year => year)
            .ToDictionary(g => g.Key, g => g.Count());

        int max = yearsMap.Values.Max();

        return yearsMap.First(kvp => kvp.Value == max).Key;
    }
}
*/

/*
using System.Collections.Generic;

public class Solution
{
    public int MaximumPopulation(int[][] logs)
    {
        var birthYears = new List<int>();
        var deathYears = new List<int>();

        foreach (var lifeSpan in logs)
        {
            birthYears.Add(lifeSpan[0]);
            deathYears.Add(lifeSpan[1]);
        }

        birthYears.Sort();
        deathYears.Sort();

        int peopleAlive = 0, maxInOneYear = 0, year = 0;
        int b = 0, d = 0;

        while (b < birthYears.Count && d < deathYears.Count)
        {
            if (birthYears[b] < deathYears[d])
            {
                peopleAlive++;

                if (maxInOneYear < peopleAlive)
                {
                    maxInOneYear = peopleAlive;
                    year = birthYears[b];
                }

                b++;
            }
            else
            {
                peopleAlive--;
                d++;
            }
        }

        return year;
    }
}
*/

using System;

public class Solution
{
    public int MaximumPopulation(int[][] logs)
    {
        var birthYears = new int[logs.Length];
        var deathYears = new int[logs.Length];

        for (int i = 0; i < logs.Length; i++)
        {
            int[] lifeSpan = logs[i];
            birthYears[i] = lifeSpan[0];
            deathYears[i] = lifeSpan[1];
        }

        Array.Sort(birthYears);
        Array.Sort(deathYears);

        int peopleAlive = 0, maxInOneYear = 0, year = 0;
        int b = 0, d = 0;

        while (b < birthYears.Length && d < deathYears.Length)
        {
            if (birthYears[b] < deathYears[d])
            {
                peopleAlive++;

                if (maxInOneYear < peopleAlive)
                {
                    maxInOneYear = peopleAlive;
                    year = birthYears[b];
                }

                b++;
            }
            else
            {
                peopleAlive--;
                d++;
            }
        }

        return year;
    }
}