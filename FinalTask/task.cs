using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {
        static int[] ArrNumbMail(string mailIndex)
        {
            int[] arrNumbMail = new int[mailIndex.Length];
            int numbMail = int.Parse(mailIndex);

            int count = 0;
            while (numbMail > 0)
            {
                int numb = numbMail % 10;
                arrNumbMail[count] = numb;
                numbMail /= 10;
                count++;
            }
            Array.Reverse(arrNumbMail);
            return arrNumbMail;
        }

        //список цифр від 0 до 10 того щоб використовувати їх в Random
        static List<int> ListUniqeNumbers()
        {
            List<int> uniqueNumbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                uniqueNumbers.Add(i);
            }
            return uniqueNumbers;
        }

        static int[,] CodeArray(List<int> uNumbers)
        {
            Random random = new Random();
            int cols = 4;
            int rows = 10;
            int[,] codeNumbMail = new int[rows, cols];
            List<string> existingRows = new List<string>();

            for (int i = 0; i < rows; i++)
            {
                List<int> copiList = new List<int>(uNumbers);
                string rowString = "";
                for (int j = 0; j < cols; j++)
                {
                    if (copiList.Count == 0)
                    {
                        return null;
                    }
                    int index = random.Next(0, copiList.Count);
                    codeNumbMail[i, j] = copiList[index];
                    copiList.RemoveAt(index);

                    rowString += codeNumbMail[i, j].ToString() + " ";
                }
                if (existingRows.Contains(rowString))
                {
                    i--;
                }
                else
                {
                    existingRows.Add(rowString);
                }
            }
            //for (int i = 0; i < codeNumbMail.GetLength(0); i++)
            //{
            //    for (int j = 0; j < codeNumbMail.GetLength(1); j++)
            //    {
            //        Console.Write(codeNumbMail[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("-----------------");
            return codeNumbMail;
        }
        static void FindIndex(int[] array, int[,] codeNumbMail)
        {
            for (int i = 0;i < array.Length;i++)
            {
                for (int j = 0; j < codeNumbMail.GetLength(1); j++)
                {

                    Console.Write($"{codeNumbMail[array[i], j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string indexMail = Console.ReadLine();
            int[] array = ArrNumbMail(indexMail);
            List<int> uniqueNumbers = ListUniqeNumbers();
            int[,] codeNumbMail = CodeArray(uniqueNumbers);
            FindIndex(array, codeNumbMail);
        }
    }
}
