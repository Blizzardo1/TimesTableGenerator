using System;

namespace TimesTableGenerator
{
    internal static class Program
    {
        private static int[,] MakeTable(int lenX, int lenY)
        {
            int[,] arr = new int[lenX, lenY];
            for (int y = 0; y < lenY; y++)
            {
                for (int x = 0; x < lenX; x++)
                {
                    arr[y, x] = (x + 1) * (y + 1);
                }
            }

            return arr;
        }
        
        private static void Main(string[] args)
        {
            int lenX = 100;
            int lenY = 100;
            
            int[,] arr = MakeTable(lenX, lenY);
            
            for (int y = 0; y < lenY; y++)
            {
                Console.Write($"| {y + 1}");
                for (int x = 0; x < lenX; x++)
                {
                    if (y == 0)
                    {
                        Console.Write($"| {x+1,5}");
                        continue;
                    }
                    Console.Write($"| {arr[y,x],5}");
                }
                Console.WriteLine();
            }
        }
    }
}