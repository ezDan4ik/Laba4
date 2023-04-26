using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
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
}