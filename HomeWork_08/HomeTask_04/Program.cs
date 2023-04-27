﻿// Задача 60:
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray3D(int[,,] array3D)
{
    string[] numbers = new string[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int count = 0;
    Random random = new Random();

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = new Random().Next(10, 18); // Диапазон указан равный количеству выводимых значений для проверки на уникальность, при необходимости можно увеличить значение до 100 (т.к. задача просить двузначное число).

                while (numbers.Contains(Convert.ToString(array3D[i, j, k])))
                {
                    array3D[i, j, k] = new Random().Next(10, 18); // Диапазон указан равный количеству выводимых значений для проверки на уникальность, при необходимости можно увеличить значение до 100 (т.к. задача просить двузначное число).
                }

                numbers[count] = Convert.ToString(array3D[i, j, k]);
                count++;
            }
        }
    }
}

void PrintArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                System.Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }

            System.Console.WriteLine();
        }
    }
}

int sheet = 2;
int rows = 2;
int columns = 2;

int[,,] array3D = new int[sheet, rows, columns];

FillArray3D(array3D);
PrintArray3D(array3D);