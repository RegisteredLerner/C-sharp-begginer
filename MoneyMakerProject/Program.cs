using System;

namespace MoneyMaker
{
  class MainClass
  {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Press amount you want to convert:");
            double coins = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(coins + " cents is equal to...");
            int gold = 10;
            int silver = 5;
            double goldCoins = Math.Floor(coins / gold);
            double remainder = coins % gold;
            double silverCoins = Math.Floor(remainder / silver);
            remainder = remainder % silver;
            Console.WriteLine("Gold coins: "+goldCoins);
            Console.WriteLine("Silver coins: "+silverCoins);
            Console.WriteLine("Bronze coins: "+remainder);


            
      
    }
  }
}
