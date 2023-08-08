using System;

namespace project {
    class Program {
        static int Reverse_number(int n = 123)
        {
            int copy_n = n;
            int count = 0;
            while (copy_n > 0) 
            {
                int res = copy_n%10;
                count += res;
                count*=10;
                copy_n/=10;
            }
            count/=10;
            return count;
        }
        static bool IsReverse(int n) 
        {
            int len = 0;
            int copy_a = n;
            double copy_two = n;
            int palid = 0;
            while (copy_a>0) 
            {
                copy_a/=10;
                len++;
            }
            if (len%2==0) 
            {
                copy_two/=Math.Pow(10, len/2);
                copy_two = copy_two - copy_two%1;
                int copy_three = Convert.ToInt32(copy_two);
                int copy_twotwo = Convert.ToInt32(copy_two);
                while (copy_three>0) 
                {
                    int r = copy_three%10;
                    copy_twotwo*=10;
                    copy_twotwo+=r;
                    copy_three/=10;
                }
                palid = copy_twotwo;
            } 
            else {
                copy_two/=Math.Pow(10, len/2);
                copy_two = copy_two - copy_two%1;
                int copy_three = Convert.ToInt32(copy_two);
                int copy_twotwo = Convert.ToInt32(copy_two);
                int copy_while = copy_three/10;
                while (copy_while>0)
                {
                    int r = copy_while%10;
                    copy_twotwo*=10;
                    copy_twotwo+=r;
                    copy_while/=10;
                }
                palid = copy_twotwo;
            }
            if (palid==n) {
                    return true;
                } else {
                    return false;
                }
        }

        static void PrintAllRequiredNumbers(int a) 
        {
            for(int y = 0; y<a; y++)  
            {   
                
                if (IsReverse(y*y)) 
                {
                    System.Console.WriteLine(y);
                }
            } 
        }
        static void Main() 
        {
            int n = int.Parse(Console.ReadLine());
            bool isPalindrome = IsReverse(n);
            System.Console.WriteLine("Чи є число паліндромом:");
            System.Console.WriteLine(isPalindrome);
            System.Console.WriteLine("Паліндром чисел, що при піднесенні до квадрата теж дають квадрат: ");
            PrintAllRequiredNumbers(n);   
        }
        
    }
}
