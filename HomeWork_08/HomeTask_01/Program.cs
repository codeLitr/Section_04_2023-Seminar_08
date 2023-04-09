// Задача 54:
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortDescendOrderInArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            for (int k = 0; k < array2D.GetLength(1) - 1; k++)
            {
                if (array2D[i, k] < array2D[i, k + 1])
                {
                    int temp = array2D[i, k + 1];
                    array2D[i, k + 1] = array2D[i, k];
                    array2D[i, k] = temp;
                }
            }
        }
    }
}

int rows = 3;
int columns = 4;

int[,] array2D = new int[rows, columns];

FillArray2D(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();

SortDescendOrderInArray2D(array2D);
PrintArray2D(array2D);