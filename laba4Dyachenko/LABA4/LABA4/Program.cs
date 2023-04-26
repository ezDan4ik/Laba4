int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

// Створюємо додатковий масив для зберігання посилань на рядки в зубчастому масиві
int[][] rowPointers = new int[3][];
for (int i = 0; i < jaggedArray.Length; i++)
{
    rowPointers[i] = jaggedArray[i];
}

// Змінюємо порядок посилань в додатковому масиві, щоб змінити порядок рядків у масиві
int[][] temp = new int[][] { rowPointers[2], rowPointers[0], rowPointers[1] };
rowPointers = temp;

// Виводимо вміст зубчастого масиву у новому порядку
for (int i = 0; i < rowPointers.Length; i++)
{
    for (int j = 0; j < rowPointers[i].Length; j++)
    {
        Console.Write(rowPointers[i][j] + " ");
    }
    Console.WriteLine();
}
