/*public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int diff = target - numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] == diff)
                {
                    return new[] {i + 1, j + 1};
                }
            }
        }

        return new[] {-1, -1};
    }
}*/

/*public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        var result = new int[2];

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                result[0] = left + 1;
                result[1] = right + 1;
                break;
            }

            if (sum < target) left++;
            if (sum > target) right--;
        }

        return result;
    }
}*/

/*public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        var result = new int[2];

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                result[0] = left + 1;
                result[1] = right + 1;
                break;
            }

            if (sum < target)
                left++;
            else right--;
        }

        return result;
    }
}*/

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        var result = new int[2];

        while (left < right)
        {
            int sum = numbers[left] + numbers[right];

            if (sum > target) right--;
            else if (sum < target) left++;
            else
            {
                result[0] = left + 1;
                result[1] = right + 1;
                break;
            }
        }

        return result;
    }
}