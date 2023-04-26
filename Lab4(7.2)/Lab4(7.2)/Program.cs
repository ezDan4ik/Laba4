using System;

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

        jaggedArray = RemoveRowsWithZeroes(jaggedArray);

        Console.WriteLine("Масив після видалення рядків з нульовими елементами:");
        PrintJaggedArray(jaggedArray);
    }


    static int[][] RemoveRowsWithZeroes(int[][] jaggedArray)
    {
        int rowsToRemove = 0;
        foreach (int[] row in jaggedArray)
        {
            if (Array.Exists(row, element => element == 0))
            {
                rowsToRemove++;
            }
        }


        int[][] newJaggedArray = new int[jaggedArray.Length - rowsToRemove][];
        int i = 0;
        foreach (int[] row in jaggedArray)
        {
            if (!Array.Exists(row, element => element == 0))
            {
                newJaggedArray[i] = row;
                i++;
            }
        }

        return newJaggedArray;
    }

    static void PrintJaggedArray(int[][] jaggedArray)
    {
        foreach (int[] row in jaggedArray)
        {
            Console.WriteLine(string.Join(" ", row));
        }
        Console.WriteLine();
    }
}

