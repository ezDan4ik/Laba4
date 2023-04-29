using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laba4GIT
{
    public partial class ezdan4ik
    {

        static int[][] FillArrayRandom(int[][] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                global::System.Console.Write("Введiть довжину :");
                int k = int.Parse(Console.ReadLine());
                arr[i] = new int[k];
            }
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(-10, 10);
                }
            }
            return arr;
        }

        static int[][] FillArrayKeyBoard(int[][] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            Console.Clear();
            return arr;
        }

        static void PrintArr(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Zapov(int[][] arr, int n)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Рандомне заповнення     - 1");
                Console.WriteLine("Заповнення з клавiатури - 2");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        FillArrayRandom(arr, n);
                        PrintArr(arr);
                        Console.WriteLine();
                        return;

                    case 2:
                        FillArrayKeyBoard(arr, n);
                        PrintArr(arr);
                        Console.WriteLine();
                        return;
                }
            } 
        }


        static void Task1()
        {
            Console.Write("Введiть кiлькiсть рядкiв: ");
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            Zapov(arr, n);
            for (int i = 0; i < arr.Length; i++)
            {
                int[] innerArray = arr[i];
                int newSize = innerArray.Length / 2 + innerArray.Length % 2;
                int[] newArray = new int[newSize];
                int newIndex = 0;
                for (int j = 0; j < innerArray.Length; j += 2)
                {
                    if (j % 2 == 0)
                    {
                        newArray[newIndex] = innerArray[j];
                        newIndex++;
                    }
                }
                arr[i] = newArray;
            }
            PrintArr(arr);
            Console.WriteLine();
        


    }
        static void Task2()
        {
            Console.Write("Введiть кiлькiсть рядкiв: ");
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];

            Zapov(arr, n);

            int newLength = 0;
            foreach (int[] row in arr)
            {
                if (!row.Contains(0))
                {
                    newLength++;
                }
            }

            int[][] newMatrix = new int[newLength][];
            int i = 0;
            foreach (int[] row in arr)
            {
                if (!row.Contains(0))
                {
                    newMatrix[i] = row;
                    i++;
                }
            }

            PrintArr(newMatrix);
        }
        public void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("Задача 1(7) - 1");
                Console.WriteLine("Задача 2(7) - 2");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                }
            } while (choice != 0);
        }
    }
}
