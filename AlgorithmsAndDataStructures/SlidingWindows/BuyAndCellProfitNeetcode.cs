namespace AlgorithmsAndDataStructures.SlidingWindows;

public static class BuyAndCellProfitNeetcode
{
    //https://neetcode.io/problems/buy-and-sell-crypto

    public static void Test()
    {
        int[] input = new int[] { 10, 1, 5, 6, 7, 1 };
        Console.WriteLine(MaxProfit(input));
    }
    
    public static int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i; j < prices.Length; j++)
            {
                int profit = prices[j] - prices[i];
                maxProfit = Math.Max(maxProfit, profit);
            }
        }

        return maxProfit;
    }
    
    public static int MaxProfitBetterSolution(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            int currentPrice = prices[i];
            minPrice = Math.Min(minPrice, currentPrice);
            maxProfit = Math.Max(maxProfit, currentPrice - minPrice);
        }

        return maxProfit;
    }
}