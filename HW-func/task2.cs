using System;

namespace project {
    class Program {
        static int SumOfDivision (int numb = 28) 
        {
             int suma_division = 0;
                for (int i = 1; i<numb; i++) 
                {
                    if (numb%i==0) 
                    {
                        suma_division+=i;    
                    }
                
                }
                return suma_division;
        }
        static void PrintAllPerfectNumbers(int a = 5)
        {   
            for (int y = 1; y<=a; y++) 
            {
                int sum_div = SumOfDivision(y);
                if (y==sum_div) 
                {   
                    System.Console.Write($"{y} ");
                }
            }
        }
        static void PrintAllAmicableNumbersPairs (int maxint) 
        {   
            int rows = maxint + 1;
            int cols = 2;
            int[,] DivisonNumbs = new int[rows, cols];
            for (int i = 1; i < rows; i++)
            {
                DivisonNumbs[i, 0] = i;
                int sum_divs = SumOfDivision(i);
                DivisonNumbs[i, 1] = sum_divs;
            }
            for (int j= 1; j<rows; j++)
            {
                for (int k = j+1; k < rows; k++)
                {
                    if (DivisonNumbs[j,0] == DivisonNumbs[k, 1] && DivisonNumbs[j, 1] == DivisonNumbs[k,0]) 
                    {
                        System.Console.WriteLine($"{DivisonNumbs[j, 0]} i {DivisonNumbs[k,0]}");
                    }
                }
            }
        }
        
        static void Main() 
        {
            int numb = int.Parse(Console.ReadLine());
            int a = SumOfDivision(numb);
            System.Console.WriteLine($"Сума дільників: {a}");
            System.Console.WriteLine("Дружні числа: ");
            PrintAllAmicableNumbersPairs(a);
            System.Console.WriteLine("Досконалі числа: ");
            PrintAllPerfectNumbers(a);
            
        }
        
    }
}
