using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laba4GIT
{
    internal class Program
    {
         public int[] array;
         public int[][] matrix;

        public static void Main(string[] args)
        {

            Program program = new Program();
            int choice;
            do
            {
                Console.WriteLine("Сюсюкало Д. - 1");
                Console.WriteLine("Дяченко М. - 2");
                Console.WriteLine("Мачульський А. - 3");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        ezdan4ik ezdan4ik = new ezdan4ik();
                        ezdan4ik.Main();
                        break;
                    case 2:
                        dito dito = new dito();
                        dito.Main();
                        break;
                    case 3:
                        holly holly = new holly();
                        holly.Main();
                        break;
                }
            } while (choice != 0);
        }
        public void PrintMatrix(int[][] matrix)
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
        public void InputJagged()
        {
            Console.WriteLine("Введите размер зубчастого массива:");
            int size = int.Parse(Console.ReadLine());
            matrix = new int[size][];
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine($"Введите количество элементов для массива {i + 1}:");
                int innerLength = int.Parse(Console.ReadLine());

                matrix[i] = new int[innerLength];

                Console.WriteLine($"Введите элементы для массива {i + 1}:");

                string[] elements = Console.ReadLine().Split(' ');
                for (int j = 0; j < innerLength; j++)
                {
                    matrix[i][j] = int.Parse(elements[j]);
                }
            }
        }
        public void FillMatrixRandom()
        {
            Console.WriteLine("Введіть розмір зубчастого массива:");
            int size = int.Parse(Console.ReadLine());
            matrix = new int[size][];
            Random random = new Random();

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine($"Введіть розмір рядка #{i + 1} зубчастого масива");
                int rows = int.Parse(Console.ReadLine());
                matrix[i] = new int[rows];

                for (int j = 0; j < rows; j++)
                {
                    matrix[i][j] = random.Next(-50, 50);
                }
            }
        }
        public void ZapovMatrix()
        {
            Program program = new Program();
        start:
            Console.WriteLine("Виберіть тип заповнення массива");
            Console.WriteLine("1.Рандом");
            Console.WriteLine("2.З клавіатури");

            int method = int.Parse(Console.ReadLine());
            switch (method)
            {
                case 1:
                    FillMatrixRandom();
                    return;
                case 2:
                    InputJagged();
                    return;
                default:
                    Console.WriteLine("Неправильно вибраний метод");
                    goto start;
            }
        }
        public void Zapovarr()
        {
        start:
            Console.WriteLine("Виберіть тип заповнення массива");
            Console.WriteLine("1.Рандом");
            Console.WriteLine("2.З клавіатури");

            int method = int.Parse(Console.ReadLine());
            switch (method)
            {
                case 1:
                    FillArrayRandom();
                    return;
                case 2:
                    InputArray();
                    return;
                default:
                    Console.WriteLine("Неправильно вибраний метод");
                    goto start;
            }

        }
        public void FillArrayRandom()
        {
            Console.WriteLine("Введите размер одномерного массива:");
            int size = int.Parse(Console.ReadLine());

            array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-50, 50);
            }
        }
        public void InputArray()
        {
            Console.WriteLine("Введите размер одномерного массива:");
            int size = int.Parse(Console.ReadLine());
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Елемент массива{i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public void PrintArray()
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
