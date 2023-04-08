// Задача 53:
// Задайте двумерный массив. Напишите программу, которая поменяет местами
// первую и последнюю строку массива.
// Например, задан массив
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

void FillArray2D(int[,] array2D)
{
    Random random = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }

        System.Console.WriteLine();
    }
}

// void SwapRowsInArray2D(int[,] array2D) // Вариант замены местами с использованием переменной temp.
// {
//     for (int j = 0; j < array2D.GetLength(1); j++) // Проходим по всем колонкам.
//     {
//         int temp = array2D[0, j]; // Берется первая строка (0) и первая колонка (i), далее переходим на след колонку (i++). Помещаем в temp первую строку.
//         array2D[0, j] = array2D[array2D.GetLength(0) - 1, j]; // Первая строка - array2D[0, i]; Последняя строка -  array2D[array2D.GetLength(0) - 1, i]. Проходим по каждой колонке и меняем местами значения из первой строки и последней. Помещаем в первую строку последнюю строку.
//         array2D[array2D.GetLength(0) - 1, j] = temp; // Помещаем в последнюю строку первую строку из temp.
//     }
// }

void SwapRowsInArray2D(int[,] array2D) // Вариант замены местами без использования переменной temp.
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        int lastRowIndex = array2D.GetLength(0) - 1;
        int firstRowIndex = 0;

        (array2D[firstRowIndex, j], array2D[lastRowIndex, j]) = (array2D[lastRowIndex, j], array2D[firstRowIndex, j]);
    }
}

int rows = 3;
int columns = 4;

int[,] array2D = new int[rows, columns];
FillArray2D(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();
SwapRowsInArray2D(array2D);
PrintArray2D(array2D);