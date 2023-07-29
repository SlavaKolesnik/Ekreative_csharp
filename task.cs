using System;
using System.Collections.Generic;

namespace ChessKnightMoves
{
    class Program
    {
        static void Main() {
            System.Console.WriteLine("Введіть суму яку бажаєте зняти, сума має бути більше 7 грн: ");
            int f = Convert.ToInt32(Console.ReadLine());
            int three_uah = 3;
            if (f>7) {
                if (f%5==0) {
                    int res = f/5;
                    System.Console.WriteLine($"суму {f}  грн можна видати по 5 грн в кількості: {res} штук");
                } else if ((f-three_uah)%5==0) {
                    int res = (f-three_uah)/5;
                    System.Console.WriteLine($"суму {f}  грн можна видати по 5 грн в кількості: {res} штук та 1 купюру номіналом 3 грн");
                } else if ((f-three_uah*2)%5==0) {
                    int res = (f-three_uah*2)/5;
                    System.Console.WriteLine($"суму {f}  грн можна видати по 5 грн в кількості: {res} штук та 2 купюру номіналом 3 грн");
                } else if ((f-three_uah*3)%5==0) {
                    int res = (f-three_uah*3)/5;
                    System.Console.WriteLine($"суму {f}  грн можна видати по 5 грн в кількості: {res} штук та 3 купюру номіналом 3 грн");
                } else if ((f-three_uah*4)%5==0) {
                    int res = (f-three_uah*4)/5;
                    System.Console.WriteLine($"суму {f}  грн можна видати по 5 грн в кількості: {res} штук та 4 купюру номіналом 3 грн");
                }
            } else {
                System.Console.WriteLine("Ваша сума менша 7 грн");
            }
        }
    }       
}

