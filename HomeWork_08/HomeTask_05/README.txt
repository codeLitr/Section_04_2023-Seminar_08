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
    //  Первая строка
    for (int i = 0; i < 4; i++)
    {
        array2D[0, i] = step++;
        //(int i = 0; 0 < 4; 0++)
        //array2D[0, 0] = 1++;

        //(int i = 1; 1 < 4; 1++)
        //array2D[0, 1] = 2++;

        //(int i = 2; 2 < 4; 2++)
        //array2D[0, 2] = 3++;

        //(int i = 3; 3 < 4; 3++)
        //array2D[0, 3] = 4++;

        //(int i = 4; 4 < 4; stop)
        //stop
    }
    // Последний столбец
    for (int i = 1; i < 4; i++)
    {
        array2D[i, 3] = step++;
        //(int i = 1; 1 < 4; 1++)
        //array2D[1, 3] = 5++;

        //(int i = 2; 2 < 4; 2++)
        //array2D[2, 3] = 6++;

        //(int i = 3; 3 < 4; 3++)
        //array2D[3, 3] = 7++;

        //(int i = 4; 4 < 4; stop)
        //stop
    }

    // Последня строка (справа налево)
    for (int i = 2; i >= 0; i--)
    {
        array2D[3, i] = step++;
        //(int i = 2; 2 >= 0; 2--)
        //array2D[3, 2] = 8++;

        //(int i = 1; 1 >= 0; 1--)
        //array2D[3, 1] = 9++;

        //(int i = 0; 0 >= 0; 0--)
        //array2D[3, 0] = 10++;

        //(int i = -1; -1 >= 0; stop)
        //stop

    }

    // Первый столбец (снизу вверх)
    for (int i = 2; i > 0; i--)
    {
        array2D[i, 0] = step++;
        //(int i = 2; 2 > 0; 2--)
        //array2D[2, 0] = 11++;

        //(int i = 1; 1 > 0; 1--)
        //array2D[1, 0] = 12++;

        //(int i = 0; 0 > 0; stop)
        //stop
    }
    // Вторая строка
    for (int i = 1; i <= 2; i++)
    {
        array2D[1, i] = step++;
        //(int i = 1; 1 < 2; 1++)
        //array2D[1, 1] = 13++;

        //(int i = 2; 2 <= 2; 2++)
        //array2D[1, 2] = 14++;

        //(int i = 3; 3 <= 2; stop)
        //stop
    }
    // Предпоследняя позиция
    for (int i = 2; i < 3; i++)
    {
        array2D[i, 2] = step++;
        //(int i = 2; 2 < 3; 2++)
        //array2D[2, 2] = 15++;

        //(int i = 3; 3 < 3; stop)
        //stop
    }
    // Последняя позиция
    for (int i = 2; i < 3; i++)
    {
        array2D[i, 1] = step++;
        //(int i = 2; 2 < 3; 2++)
        //array2D[2, 2] = 15++;

        //(int i = 3; 3 < 3; stop)
        //stop
    }
}

int rowsAndColumns = 4;
int[,] array2D = new int[rowsAndColumns, rowsAndColumns];

FillSpiralArray(array2D);
PrintArray2D(array2D);


//ВТОРОЙ ВАРИАНТ:

// int n = 4; // размер массива
// int[,] arr = new int[n, n]; // создаем пустой массив

// int[][] directions = new int[][] 
// {
//     new int[] {0, 1}, // направление "вправо"
//     new int[] {1, 0}, // направление "вниз"
//     new int[] {0, -1}, // направление "влево"
//     new int[] {-1, 0} // направление "вверх"
// };

// int directionIndex = 0; // начальное направление "вправо"
// int row = 0; // начальная строка
// int col = 0; // начальный столбец

// for (int i = 1; i <= n * n; i++)
// {
//     arr[row, col] = i; // записываем значение в текущую ячейку

//     int[] direction = directions[directionIndex]; // получаем текущее направление
//     int nextRow = row + direction[0]; // вычисляем следующую строку
//     int nextCol = col + direction[1]; // вычисляем следующий столбец

//     // если следующая ячейка находится за пределами массива или уже заполнена, меняем направление
//     if (nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n || arr[nextRow, nextCol] != 0)
//     {
//         directionIndex = (directionIndex + 1) % 4; // меняем направление
//         direction = directions[directionIndex]; // получаем новое направление
//         nextRow = row + direction[0]; // вычисляем следующую строку
//         nextCol = col + direction[1]; // вычисляем следующий столбец
//     }

//     row = nextRow; // обновляем текущую строку
//     col = nextCol; // обновляем текущий столбец
// }

// void PrintArray2D(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             // Добавлен вывод двузначного числа у значений до 10, для соответствия примеру в условиях.             
//             System.Console.Write(arr[i, j].ToString("D2") + " ");
//         }

//         System.Console.WriteLine();
//     }
// }
// PrintArray2D(arr);