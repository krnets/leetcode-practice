public class Solution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int drunk = numBottles;

        while (numBottles >= numExchange)
        {
            int remains = numBottles % numExchange;
            int extraAfterExchange = numBottles / numExchange;

            drunk += extraAfterExchange;
            numBottles = remains + extraAfterExchange;
        }

        return drunk;
    }
}