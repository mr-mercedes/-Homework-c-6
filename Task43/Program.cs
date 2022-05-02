// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
double ImputNumber (string numberName)
{
    Console.Write($"Введите число {numberName}: ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

Console.WriteLine("Введите четыре числа");
double b1 = ImputNumber("b1");
double b2 = ImputNumber("b2");
double k1 = ImputNumber("k1");
double k2 = ImputNumber("k2");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
double point1 = k1 * x + b1;
double point2 = k2 * x + b2;
Console.WriteLine($"Точка b1 = {b1}, точка b2 = {b2}");
Console.WriteLine($"Точка k1 = {k1}, точка k2 = {k2}");
Console.WriteLine($"Точка х = {x}, точка у = {y}");
Console.WriteLine($"Точка point1 = {point1}, точка point2 = {point2}");