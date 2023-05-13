using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4GIT
{
    internal class holly
    {
        public Program program = new Program();
        public void Main()
        {
        start:
            Console.WriteLine("Виберіть який блок ви хочете запустить");
            Console.WriteLine("1. Блок1");
            Console.WriteLine("2. Блок2");
            int method = int.Parse(Console.ReadLine());
            switch (method)
            {
                case 1:
                    program.Zapovarr();
                    DelPar();
                    return;
                case 2:
                    program.ZapovMatrix();
                    DelRows();
                    return;
                default:
                    Console.WriteLine("Алло подивись внімательніше");
                    goto start;
            }
        }       
        private void DelRows()
        {

            Console.WriteLine("Готовий Массив:");
            program.PrintMatrix(program.matrix);
            Console.WriteLine("Введіть рядок K1");
            int k1 = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Введіть рядок K2");
            int k2 = int.Parse(Console.ReadLine()) - 1;


            int numRows = program.matrix.Length;


            if (k1 >= 0 && k1 <= numRows - 1 && k2 >= k1 && k2 <= numRows - 1)
            {
                int numToDelete = k2 - k1 + 1;
                int numToShift = numRows - k2 - 1;

                Array.Copy(program.matrix, k2 + 1, program.matrix, k1, numToShift);

                Array.Resize(ref program.matrix, numRows - numToDelete);
            }
            Console.WriteLine("Результат:");
            program.PrintMatrix(program.matrix);
            Console.ReadLine();
        }


        private void DelPar()
        {
            Console.WriteLine("Вхідний масив:");
            program.PrintArray();
            int count = 1;
            for (int i = program.array.Length-1; i >= 0; i--)
            {
                if (i % 2 != 0)
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
    }

}
