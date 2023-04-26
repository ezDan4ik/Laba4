using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Введіть кількість рядків і стовпців матриць A і B: ");
        int n = int.Parse(Console.ReadLine());

        int[,] a = ReadMatrixFromConsole(n);
        int[,] b = ReadMatrixFromConsole(n);


        int[] r = new int[n * n];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] == b[i, j])
                {
                    r[k] = a[i, j];
                    k++;
                }
            }
        }

        Console.Write("Введіть число s: ");
        int s = int.Parse(Console.ReadLine());

        int aIndex = -1, bIndex = -1;
        for (int i = 0; i < k; i++)
        {
            if (r[i] == s)
            {
                if (aIndex == -1)
                    aIndex = i;
                bIndex = i;
            }
        }

        if (bIndex != -1)
        {
            if (aIndex != -1)
            {
                a[aIndex % n, bIndex % n] = s;
            }
            else
            {
                b[bIndex % n, aIndex % n] = s;
            }
        }
        else
        {
            Console.WriteLine($"Число {s} не зустрічається в масиві R більше двох разів.");
            return;
        }

        if (aIndex != -1 && bIndex != -1 && bIndex - aIndex > 1)
        {
            b[bIndex % n, aIndex % n] = s;
        }
        else if (bIndex - aIndex == 1)
        {
            a[aIndex % n, bIndex % n] = s;
        }
        else
        {
            Console.WriteLine($"Число {s} зустрічається менше 2 разів у масиві R.");
        }


        Console.WriteLine("Матриця A:");
        PrintMatrix(a);
        Console.WriteLine("Матриця B:");
        PrintMatrix(b);
    }

    public static int[,] ReadMatrixFromConsole(int n)
    {
        Console.WriteLine($"Введіть елементи матриці {n}x{n}, розділені пробілами:");

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(row[j]);
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}