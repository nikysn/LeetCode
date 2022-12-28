namespace Tasks;

public class MaxProfit 
{
    public int MaxProfitt(int[] prices)
    {
        int sell = prices[prices.Length - 1];
        int profit = 0;

            for (int i = prices.Length - 2; i >=0; i--)
            {
                if(sell - prices[i] > profit)
                {
                    profit = sell - prices[i];
                }
                else if (prices[i] > sell)
                {
                    sell = prices[i];
                }
               
            }
            return profit;
    }
}