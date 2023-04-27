// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// 2 * 3 + 4 * 3 = 18 | 2 * 4 + 4 * 3 = 20
// 3 * 3 + 2 * 3 = 15 | 3 * 4 + 2 * 3 = 18
//Количество столбцов 1-й матрицы должно быть равно количеству строк 2-й матрицы.

void FillMatrix(int[,] arrayMatrix) // Создание и заполнение двух двумерных массивов (матриц).
{
    Random random = new Random();
    for (int i = 0; i < arrayMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMatrix.GetLength(1); j++)
        {
            arrayMatrix[i, j] = random.Next(1, 10);
        }
    }
}

void PrintTwoMatrix(int[,] matrixLeft, int[,] matrixRight) // Вывод массива в консоль в формате в соответствии с заданием. 
{
    for (int i = 0; i < matrixLeft.GetLength(0); i++)
    {
        for (int j = 0; j < matrixLeft.GetLength(1); j++)
        {
            Console.Write(matrixLeft[i, j] + " ");
        }
        Console.Write("| ");

        for (int j = 0; j < matrixRight.GetLength(1); j++)
        {
            Console.Write(matrixRight[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintResultMatrix(int[,] arrayMatrix) 
// Отдельный метод для вывода результата - сделан, в связи с форматом вывода изначальных двух матриц. 
// При исключении разделителя матриц и выводе их друг под другом, возможно использование одного метода для всех выводов в консоль.
{
    for (int i = 0; i < arrayMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMatrix.GetLength(1); j++)
        {
            System.Console.Write("{0,4}", arrayMatrix[i, j] + " ");
        }

        System.Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] matrixLeft, int[,] matrixRight) // Перемножение двух матриц.
{
    int[,] resultM = new int[matrixLeft.GetLength(0), matrixRight.GetLength(1)];

    for (int i = 0; i < matrixLeft.GetLength(0); i++)
    {
        for (int j = 0; j < matrixRight.GetLength(1); j++)
        {
            for (int k = 0; k < matrixLeft.GetLength(1); k++)
            {
                resultM[i, j] += matrixLeft[i, k] * matrixRight[k, j];
            }
        }
    }

    return resultM;
}

int rows = 3;
int columns = 3;
int[,] matrixLeft = new int[rows, columns];
int[,] matrixRight = new int[rows, columns];

FillMatrix(matrixLeft);
FillMatrix(matrixRight);
PrintTwoMatrix(matrixLeft, matrixRight);
System.Console.WriteLine();

int[,] result = MultiplyMatrix(matrixLeft, matrixRight);
PrintResultMatrix(result);