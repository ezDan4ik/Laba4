using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4GIT
{
    public partial class holly
    {
        public void Main()
        {
        start:
            Console.WriteLine("Виберіть який блок ви хочете запустить");
            Console.WriteLine("1. Блок1");
            Console.WriteLine("2. Блок2");
            int method = int.Parse(Console.ReadLine());
            int[] array;
            int[][] matrix;
            switch (method)
            {
                case 1:
                    Console.Write("Вы запустили блок1 введіть розмір массиву:");
                    int size = int.Parse(Console.ReadLine());
                    array = new int[size];
                    InputArray(array);
                    DelPar(array);
                    return;
                case 2:
                    Console.Write("Вы запустили блок1 введіть кількість рядків массиву:");
                    int rows = int.Parse(Console.ReadLine());
                    Console.Write("Введіть кількість стовбців массиву:");
                    int cols = int.Parse(Console.ReadLine());
                    matrix = new int[rows][];
                    InputJagged(matrix, cols, rows);
                    DelRows(matrix, cols, rows);
                    return;
                default:
                    Console.WriteLine("Алло подивись внімательніше");
                    goto start;
            }
        }
        private static void InputJagged(int[][] matrix, int cols, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"Введи елемент[{i + 1},{j + 1}]: ");
                    matrix[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        
        private static void DelRows(int[][] matrix, int cols, int rows)
        {

            Console.WriteLine("Готовий Массив:");
            PrintMatrix(matrix);
            Console.WriteLine("Введіть рядок K1");
            int k1 = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Введіть рядок K2");
            int k2 = int.Parse(Console.ReadLine()) - 1;


            int numRows = matrix.Length;


            if (k1 >= 0 && k1 <= numRows - 1 && k2 >= k1 && k2 <= numRows - 1)
            {
                int numToDelete = k2 - k1 + 1;
                int numToShift = numRows - k2 - 1;

                Array.Copy(matrix, k2 + 1, matrix, k1, numToShift);

                Array.Resize(ref matrix, numRows - numToDelete);
            }
            Console.WriteLine("Результат:");
            PrintMatrix(matrix);
            Console.ReadLine();
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] != null)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        Console.Write(matrix[i][j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }
        }

        private static void DelPar(int[] array)
        {
            Console.WriteLine("Вхідний масив:");
            PrintArray(array);
            int count = 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    count++;
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }

                }
            }
            Array.Resize(ref array, count);

            // Вивід масиву після знищення елементів
            Console.WriteLine("Масив після знищення елементів:");
            PrintArray(array);
            Console.ReadLine();
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        private static void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Елемент массива{i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }

}
