using System;
using System.Linq;

namespace Laba4GIT
{
    internal class dito
    {
        public Program program = new Program();
        
        private void Task1()
        {
            Console.WriteLine("Початковий масив:");
            program.PrintArray();

            for (int i = 0; i < program.array.Length; i++)
            {
                if (program.array[i] < 0)
                {
                    int abs = Math.Abs(program.array[i]);
                    Array.Resize(ref program.array, program.array.Length + 1);
                    for (int j = program.array.Length - 1; j > i + 1; j--)
                    {
                        program.array[j] = program.array[j - 1];
                    }
                    program.array[i + 1] = abs;
                    if (i > 0 && program.array[i - 1] < 0)
                    {
                        abs = Math.Abs(program.array[i - 1]);
                    }
                    i++;
                }
            }

            Console.WriteLine("Масив після вставлення модулів від’ємних елементів:");
            program.PrintArray();

        }
        private void Task2()
        {
            Console.WriteLine("Початковий масив:");
            program.PrintMatrix(program.matrix);

            int maxRowIndex = 0;
            int maxElement = int.MinValue;

            for (int i = 0; i < program.matrix.Length; i++)
            {
                int rowMax = program.matrix[i].Max();
                if (rowMax >= maxElement)
                {
                    maxElement = rowMax;
                    maxRowIndex = i;
                }
            }

            int[][] newJaggedArray = new int[program.matrix.Length + 1][];
            int j = 0;
            for (int i = 0; i < newJaggedArray.Length; i++)
            {
                if (i == maxRowIndex)
                {
                    newJaggedArray[i] = new int[program.matrix[0].Length];
                    Console.Write($"Введіть елементи рядка, який потрібно вставити перед рядком з максимальним елементом: ");
                    string inputRow = Console.ReadLine();
                    string[] elements = inputRow.Split(' ');
                    newJaggedArray[i] = Array.ConvertAll(elements, int.Parse);
                }
                else
                {
                    newJaggedArray[i] = program.matrix[j];
                    j++;
                }
            }

            program.matrix = newJaggedArray;

            Console.WriteLine("Масив після додавання рядка перед рядком з максимальним елементом:");
            program.PrintMatrix(program.matrix);
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
                        program.Zapovarr();
                        Task1();
                        break;
                    case 2:
                        program.ZapovMatrix();
                        Task2();
                        break;
                }
            } while (choice != 0);
        }
    }
}