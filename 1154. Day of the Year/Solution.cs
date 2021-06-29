using System;
using System.Linq;

/*public class Solution
{
    public int DayOfYear(string date)
    {
        return DateTime.Parse(date).DayOfYear;
    }
}*/

public class Solution
{
    public int DayOfYear(string date)
    {
        var arr = date.Split('-').Select(int.Parse).ToArray();
        int year = arr[0];
        int month = arr[1];
        int day = arr[2];
        int countDays = day;
        bool isLeap = IsLeapYear(year);
        int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        if (isLeap)
            daysInMonth[1]++;

        for (int i = 0; i < month - 1; i++)
            countDays += daysInMonth[i];

        return countDays;
    }

    private bool IsLeapYear(int year)
    {
        return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
    }
}