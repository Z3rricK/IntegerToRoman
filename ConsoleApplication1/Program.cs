using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public int intToRoman(int number)
        {
            int[] num = {1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000};
            string[] sym = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            
            int i = num.Length - 1;

            while (number > 0)
            {
                int div = number / num[i];
                number %= num[i];

                for (int j = div; j > 0; j--)
                {
                    Console.Write(sym[i]);
                }
                i--;
            }
            return 0;
        }
        
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.intToRoman(59);
        }
    }
}