using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laba4GIT
{
    internal class ezdan4ik
    {
        public Program program = new Program();

        private void Task1()
        {
            Console.WriteLine("Вхідний масив:");
            program.PrintArray();
            int count = -1;
            for (int i = program.array.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    count++;
                    for (int j = i; j < program.array.Length - 1; j++)
                    {
                        program.array[j] = program.array[j + 1];
                    }

                }
            }
            Array.Resize(ref program.array, count);
            Console.WriteLine("Масив після знищення елементів:");
            program.PrintArray();
            Console.ReadLine();
        }
        public void Task2()
        {
            int newLength = 0;
            foreach (int[] row in program.matrix)
            {
                if (!row.Contains(0))
                {
                    newLength++;
                }
            }

            int[][] newMatrix = new int[newLength][];
            int i = 0;
            foreach (int[] row in program.matrix)
            {
                if (!row.Contains(0))
                {
                    newMatrix[i] = row;
                    i++;
                }
            }
            Console.WriteLine("");
            program.PrintMatrix(newMatrix);
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
                        program.Zapovarr();
                        Task1();
                        return;
                    case 2:
                        program.ZapovMatrix();
                        Task2();
                        return;
                }
            } while (choice != 0);
        }
    }
}
