using System;

namespace Best_Time_to_Buy_and_Sell_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            // {7,2,3,8}
            Console.WriteLine("Enter size of array !");
            int n = int.Parse(Console.ReadLine());
            int[] prices = new int[n];
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = int.Parse(Console.ReadLine());
            }
            //int n = sizeof(prices) / sizeof(prices[0]);
            int max_profit = MaxProfit(prices);
            Console.WriteLine(max_profit);
        }
        public static int MaxProfit(int[] prices)
        {
            int buy = prices[0], max_profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {

                // Checking for lower buy value
                if (buy > prices[i])
                    buy = prices[i];

                // Checking for higher profit
                else if (prices[i] - buy > max_profit)
                    max_profit = prices[i] - buy;
            }
            return max_profit;

        }
    }
}
