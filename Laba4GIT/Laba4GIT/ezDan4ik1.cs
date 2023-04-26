using System;

class Program
{
    static void Main(string[] args)
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

        for (int i = 1; i < arr.Length; i += 2)
        {
            for (int j = i; j < arr.Length - 1; j++)
            {
                arr[j] = arr[j + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }

        Console.WriteLine("Масив після видалення елементів з непарними індексами:");
        PrintArray(arr);

        Console.ReadKey();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

