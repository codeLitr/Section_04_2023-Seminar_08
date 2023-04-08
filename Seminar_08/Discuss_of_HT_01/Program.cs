// Обсуждение домашнего задания к Семинару №6:

// Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// МОЙ Вариант решения:

// int HowManyNumbersYouWant(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int howMany = HowManyNumbersYouWant("Введите требуемое кол-во чисел: ");

// int[] numbers = new int[howMany];
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = HowManyNumbersYouWant($"Введите число {i + 1}: ");
// }

// Console.Write("{0}", string.Join(", ", numbers) + " -> ");

// int HowManyNumbersHigherZero(int[] numbers)
// {
//     int count = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > 0)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }

// System.Console.WriteLine(HowManyNumbersHigherZero(numbers));


// Вариант решения преподавателя:

int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNumberWithMessage($"Введите {i + 1} число: ");
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count = count + 1;

    }
    return count;
}

int length = InputNumberWithMessage("Введите количество чисел: ");
int[] nunbers = new int[length];

FillArray(nunbers);
PrintArray(nunbers);

int result = CountPositiveNumbers(nunbers);

System.Console.WriteLine();
System.Console.WriteLine($"Количество положительных чисел: {result}");