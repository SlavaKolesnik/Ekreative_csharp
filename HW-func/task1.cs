using System;

namespace project {
    class Program {
        static int GreatestCommonDivision(int a, int b)
        {
            while (b != 0)
            {
                int max_div = b;
                b = a % b;
                a = max_div;
            }
            return a;
        }

        static void PrintAllFracs(int n)
        {
            for (int  zn = 2; zn <= n; zn++)
            {
                for (int ch = 1; ch < zn; ch++)
                {
                    if (GreatestCommonDivision(ch, zn) == 1)
                    {
                        Console.WriteLine($"{ch}/{zn}"); 
                    }
                }
            }
        }
        
        static bool IsFracIrreducible (int a, int b)
        {
            return GreatestCommonDivision(a, b) == 1;

        }
        

        static void Main(string[] args)
        {
            Console.Write("Введіть максимальний знаменник: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Нескоротні дроби зі знаменниками, не більше {n}:");
            PrintAllFracs(n);
            System.Console.WriteLine("Введіть дріб через '/'");
            string a_b = Console.ReadLine();
            string[] numb = a_b.Split("/");
            int a = int.Parse(numb[0]);
            int b = int.Parse(numb[1]);
            
            if (IsFracIrreducible(a, b))
                System.Console.WriteLine("Нескоротний дріб");
            else
                System.Console.WriteLine("Скоротний дріб");        
        }
        
    }
}
