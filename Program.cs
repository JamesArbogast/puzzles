using System;
using System.Collections.Generic;

namespace puzzles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Functions fnct = new Functions();
            int[] arrayTen = new int[10];
            fnct.RandomArray(arrayTen);
            fnct.TossCoin();
            fnct.TossMultipleCoins(20);
            fnct.Names();
        }
    }
}
