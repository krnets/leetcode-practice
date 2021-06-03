public class Solution
{
    public int AddDigits(int num)
    {
        int digitSum = 0;

        while (num > 0)
        {
            digitSum += num % 10;
            num /= 10;
        }

        return digitSum < 10 ? digitSum : AddDigits(digitSum);
    }
}


/*public class Solution
{
    public int AddDigits(int num)
    {
        while (true)
        {
            int digitSum = 0;

            while (num > 0)
            {
                digitSum += num % 10;
                num /= 10;
            }

            if (digitSum < 10)
                return digitSum;

            num = digitSum;
        }
    }
}*/