using System;
using System.Linq;

namespace Laba4forgit
{
    public partial class dito
    {
        static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static int[][] InsertRowBeforeMaxElementRow(int[][] jaggedArray)
        {
            int maxRowIndex = 0;
            int maxElement = int.MinValue;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int rowMax = jaggedArray[i].Max();
                if (rowMax >= maxElement)
                {
                    maxElement = rowMax;
                    maxRowIndex = i;
                }
            }

            int[][] newJaggedArray = new int[jaggedArray.Length + 1][];
            int j = 0;
            for (int i = 0; i < newJaggedArray.Length; i++)
            {
                if (i == maxRowIndex)
                {
                    newJaggedArray[i] = new int[jaggedArray[0].Length];
                }
                else
                {
                    newJaggedArray[i] = jaggedArray[j];
                    j++;
                }
            }

            Console.Write($"Введіть елементи рядка, який потрібно вставити перед рядком з максимальним елементом: ");
            string[] elements = Console.ReadLine().Split(' ');
            for (int i = 0; i < elements.Length; i++)
            {
                newJaggedArray[maxRowIndex][i] = int.Parse(elements[i]);
            }

            return newJaggedArray;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        static void Task1()
        {
            Console.Write("Введіть кількість елементів масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть {i + 1}-й елемент масиву: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Початковий масив:");
            PrintArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    int abs = Math.Abs(arr[i]);
                    Array.Resize(ref arr, arr.Length + 1);
                    for (int j = arr.Length - 1; j > i + 1; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[i + 1] = abs;
                    if (i > 0 && arr[i - 1] < 0)
                    {
                        abs = Math.Abs(arr[i - 1]);
                    }
                    i++;
                }
            }

            Console.WriteLine("Масив після вставлення модулів від’ємних елементів:");
            PrintArray(arr);

        }
        static void Task2()
        {
            Console.WriteLine("Введіть кількість рядків");
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Введіть елементи рядка {i + 1}: ");
                string[] elements = Console.ReadLine().Split(' ');
                jaggedArray[i] = new int[elements.Length];
                for (int j = 0; j < elements.Length; j++)
                {
                    jaggedArray[i][j] = int.Parse(elements[j]);
                }
            }
            Console.WriteLine("Початковий масив:");
            PrintJaggedArray(jaggedArray);

            jaggedArray = InsertRowBeforeMaxElementRow(jaggedArray);

            Console.WriteLine("Масив після додавання рядка перед рядком з максимальним елементом:");
            PrintJaggedArray(jaggedArray);
        }
        public void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("Задача 1(12) - 1");
                Console.WriteLine("Задача 2(12) - 2");
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