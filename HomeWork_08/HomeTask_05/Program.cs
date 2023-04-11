// Задача 62:
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            // Добавлен вывод двузначного числа у значений до 10, для соответствия примеру в условиях.             
            System.Console.Write(array2D[i, j].ToString("D2") + " ");
        }

        System.Console.WriteLine();
    }
}

void FillSpiralArray(int[,] array2D)
{
    int step = 1;
    for (int i = 0; i < 4; i++)
    {
        array2D[0, i] = step++;
    }
    for (int i = 1; i < 4; i++)
    {
        array2D[i, 3] = step++;
    }
    for (int i = 2; i >= 0; i--)
    {
        array2D[3, i] = step++;
    }
    for (int i = 2; i > 0; i--)
    {
        array2D[i, 0] = step++;
    }
    for (int i = 1; i <= 2; i++)
    {
        array2D[1, i] = step++;
    }
    for (int i = 2; i < 3; i++)
    {
        array2D[i, 2] = step++;
    }
    for (int i = 2; i < 3; i++)
    {
        array2D[i, 1] = step++;
    }
}

int rowsAndColumns = 4;
int[,] array2D = new int[rowsAndColumns, rowsAndColumns];

FillSpiralArray(array2D);
PrintArray2D(array2D);