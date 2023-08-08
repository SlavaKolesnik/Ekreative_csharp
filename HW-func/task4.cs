using System;

namespace project {
    class Program {
        static int[] CalcNumberOfDigits(int i) 
        {
            int len = 0;
            int copy_i = i;
            while (copy_i>0) 
            {
                copy_i/=10;
                len++;
            }
            int[] numbs = new int[len];
            int el = 0;
            while (i>0) 
            {
                int r = i%10;
                numbs[el] += r;
                i/=10;
                el++;
                
            }
            return numbs;
        }
        static int CalcSumOfDigitsPowers(int[] numbs) 
        {
            int calc_sum = 0;
            foreach (int el in numbs) 
            {
                calc_sum += (int)Math.Pow(el, 3);
            }
            return calc_sum;
        }
        static bool IsArmstrongNumber(int i, int calc_sum) 
        {
            if (i==calc_sum)
            {
                return true;
            } else {
                return false;
            }
        }
        static void PrintAllArmstrongNumbers(int a)
        {
            for (int j=2; j<=a; j++)
            {
                int[] numbs = CalcNumberOfDigits(j);
                int calc_sum = CalcSumOfDigitsPowers(numbs);
                if (IsArmstrongNumber(j, calc_sum))
                {
                    System.Console.WriteLine(j);
                }
            }
        }
        public static void Main() 
        {
            int i = int.Parse(Console.ReadLine());
            int[] numbs = CalcNumberOfDigits(i);
            int a = CalcSumOfDigitsPowers(numbs);
            System.Console.WriteLine("Сума кубів цифер числа: ");
            System.Console.WriteLine(a);
            System.Console.WriteLine("Чи є число числом Армстронга: ");
            System.Console.WriteLine(IsArmstrongNumber(i, a));
            System.Console.WriteLine("Числа Армстронга:");
            PrintAllArmstrongNumbers(i);     
        }
        
    }
}
