/*public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        int increasing = 0;
        int switchCount = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] > 0)
            {
                if (increasing == -1)
                    switchCount++;

                increasing = 1;
            }
            else if (arr[i - 1] - arr[i] > 0)
            {
                if (increasing == 1)
                    switchCount++;

                increasing = -1;
            }
            else return false;
        }

        return switchCount == 1 && increasing == -1;
    }
}*/

public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3) return false;

        int i = 1;

        while (i < arr.Length && arr[i - 1] < arr[i])
            i++;

        if (i == 1 || i == arr.Length)
            return false;

        while (i < arr.Length && arr[i - 1] > arr[i])
            i++;

        return i == arr.Length;
    }
}