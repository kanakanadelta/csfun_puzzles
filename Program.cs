using System;

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
            while(idx < 10)
            {
                int rNum = rand.Next(5, 25);
                if(rNum < min) 
                {
                    min = rNum;
                }
                if(rNum > max)
                {
                    max = rNum;
                }
                result[idx] = rNum;
                sum+=rNum;
                idx++;
            }
            Console.WriteLine($"Min: {min}, Max: {max}");
            Console.WriteLine($"Sum of all values: {sum}");
            return result;
        }
        // // // //
        // MAIN //
        static void Main(string[] args)
        {
            Console.WriteLine("Puzzles Practice");
            RandomArray();
        }
    }
}
