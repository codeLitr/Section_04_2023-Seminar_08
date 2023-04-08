// Задача 55:
// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// [nXn]
// Например, задан массив
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

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

void PrintMatrixTransposeInArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[j, i] + " ");
        }

        System.Console.WriteLine();
    }
}

// int[,] MatrixTransposeInArray2D(int[,] array2D)
// {
//     int rows = array2D.GetLength(1);
//     int сolumns = array2D.GetLength(0);
//     int[,] newArray2D = new int[rows, сolumns];

//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             newArray2D[j, i] = array2D[i, j];
//         }
//     }
//     return newArray2D;
// }

int rows = 4;
int сolumns = 4;

int[,] array2D = new int[rows, сolumns];

FillArray2D(array2D);
PrintArray2D(array2D);
// array2D = MatrixTransposeInArray2D(array2D);
System.Console.WriteLine();
PrintMatrixTransposeInArray2D(array2D);