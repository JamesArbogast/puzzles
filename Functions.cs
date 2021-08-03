using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
{
    public class Functions
    {
        Random rnd = new Random();
        public int[] RandomArray(int[] arrayTen)
        {
            int max = 5;
            int min = 5;
            int sum = 5;
            for(int i = 0; i < arrayTen.Length; i++)
            {
                arrayTen[i] = rnd.Next(5, 25);
                sum += arrayTen[i];
                if(arrayTen[i] < min)
                {
                    min = arrayTen[i];
                }
                if(arrayTen[i] > max)
                {
                    max = arrayTen[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            return arrayTen;
        }

        public string TossCoin()
        {
            int coinNum = rnd.Next(1, 3);
            Console.WriteLine("CoinNum: " + coinNum);
            string flip = "";
            if (coinNum == 1)
            {
                flip = "Heads";
            }
            else if (coinNum == 2)
            {
                flip = "Tails";
            }
            Console.WriteLine(flip);
            return flip;

        }

        public double TossMultipleCoins(int num)
        {
            List<string> coinResults = new List<string>();
            int countDown = num;
            int heads = 0;
            int tails = 0;
            while (countDown > 0)
            {
                coinResults.Add(TossCoin());
                countDown--;
            }

            foreach (string rez in coinResults)
            {
                if(rez == "Heads")
                {
                    heads++;
                }
                if(rez == "Tails")
                {
                    tails++;
                }
            }
            double resultPer = (double)heads / (double)num;
            Console.WriteLine(resultPer);
            return resultPer;
        }

        public List<string> Names()
        {
            List<string> names = new List<string> {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            var randomized = names.OrderBy(item => rnd.Next());
            List<string> newNames = new List<string>();
            foreach (string name in randomized)
            {
                if(name.Length >= 5)
                {
                    newNames.Add(name);
                    Console.WriteLine(name);
                }
            }
            return newNames;
        }
    }
}