// Задача 56:
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindStringLowerSum(int[,] array2D)
{
    int minRowIndex = 0;
    int minRowSum = int.MaxValue;

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            rowSum += array2D[i, j];
        }
        if (rowSum < minRowSum)
        {
            minRowIndex = i;
            minRowSum = rowSum;
        }
    }

    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex}");
}

int rows = 4;
int columns = 4;

int[,] array2D = new int[rows, columns];

FillArray2D(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();

FindStringLowerSum(array2D);

