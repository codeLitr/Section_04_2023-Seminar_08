// Задача 57: 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Пример. Есть набор данных
// { 1, 9, 9, 0, 2, 8, 0, 9 }

// Частотный массив можно представить так
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(String.Join(',', array));
}

void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i; j < array.Length; j++)
        {
            if (array[i] > array[j])
                (array[i], array[j]) = (array[j], array[i]);
        }
    }
}
void CheckFrequencyInArray(int[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            System.Console.WriteLine($"{array[i]} встречается {count} раза");
        }
        else if (array[i] == array[i + 1])
        {
            count++;
        }
        else
        {
            System.Console.WriteLine($"{array[i]} встречается {count} раза");
            count = 1;
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
int[] Convert2DArrayToArray(int[,] array2D)
{
    int rows = array2D.GetLength(0);
    int сolumns = array2D.GetLength(1);

    int[] oneDemensionArray = new int[rows * сolumns];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            oneDemensionArray[i * сolumns + j] = array2D[i, j];
        }
    }

    return oneDemensionArray;
}

int size = 10;
int rows = 3;
int сolumns = 4;

// int[] testOneDemensionArray = new int[size];
// FillArray(testOneDemensionArray);
// PrintArray(testOneDemensionArray);

// BubbleSort(testOneDemensionArray);
// PrintArray(testOneDemensionArray);
// CheckFrequencyInArray(testOneDemensionArray);

int[,] array2D = new int[rows, сolumns];

FillArray2D(array2D);
PrintArray2D(array2D);
int[] array = Convert2DArrayToArray(array2D);
PrintArray(array);
BubbleSort(array);
PrintArray(array);
CheckFrequencyInArray(array);