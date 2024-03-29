﻿using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static int[] RandomArray(){
            int[] result = new int[10];
            Random rand = new Random();
            int firstNum = rand.Next(5, 25);
            int min = firstNum;
            int max = firstNum;
            int sum = firstNum;
            
            int idx = 1;
            while(idx < 10){
                int rNum = rand.Next(5, 25);
                if(rNum < min) 
                    min = rNum;
                if(rNum > max)
                    max = rNum;
                result[idx] = rNum;
                sum+=rNum;
                idx++;
            }
            Console.WriteLine($"Min: {min}, Max: {max}");
            Console.WriteLine($"Sum of all values: {sum}");
            return result;
        }
        public static string TossCoin(){
            Random rand = new Random();
            Console.WriteLine("Tossing a coin...");
            int result = rand.Next(0,2);
            if(result == 0) 
            {
                Console.WriteLine($"Tails, {result}");
                return "Tails";
            } else 
            {
                Console.WriteLine($"Heads, {result}");
                return "Heads";
            }
        }

        public static double TossMultipleCoins(int num)
        {
            int wins = 0;
            int tossCount = 0;
            Console.WriteLine("Multiple Coin Toss, start");
            while(tossCount < num)
            {
                string coinToss = TossCoin();
                if(coinToss == "Heads")
                    Console.WriteLine("you won a toss!");
                    wins++;
                tossCount++;
            }
            double winRatio = (double)wins/num;
            Console.WriteLine($"wins ratio at: {winRatio*100}/100");
            return winRatio*100;
        }
        public static List<string> Names(){
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");

            Random rand = new Random();
            int idx = 0;

            for(int currIdx = idx; currIdx < names.Count; currIdx++) {
                string temp = names[currIdx];
                int rIdx = rand.Next(currIdx, names.Count);
                names[currIdx] = names[rIdx];
                names[rIdx] = temp;
                idx++;
            }

            string namesStr = string.Join(",", names);
            Console.WriteLine(namesStr);
            return names;
        }
        // // // //
        // MAIN //
        static void Main(string[] args)
        {
            Console.WriteLine("Puzzles Practice");
            RandomArray();
            TossCoin();
            TossMultipleCoins(10);
            Names();
        }
    }
}
