// Обсуждение домашнего задания к Семинару №6:

// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// МОЙ Вариант решения:

// System.Console.Write("Введите точку b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите точку k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите точку b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите точку k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());

// var x = -(b1 - b2) / (k1 - k2);
// var y = k1 * x + b1;

// x = Math.Round(x, 3);
// y = Math.Round(y, 3);

// System.Console.WriteLine($"Пересечение в точке: ({x};{y})");


// Вариант решения преподавателя:

double InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double k1 = InputNumberWithMessage("Введите к1: ");
double b1 = InputNumberWithMessage("Введите b1: ");

double k2 = InputNumberWithMessage("Введите k2: ");
double b2 = InputNumberWithMessage("Введите b2: ");

double x = (b2 - b1) / (k1 - k2);
double y = x * k1 + b1;

System.Console.WriteLine("Координаты точки пересечения:");
System.Console.WriteLine($"x = {x}");
System.Console.WriteLine($"y = {y}");