﻿// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
void Fillrray(int[] array)   
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write($"Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void WriteArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Write("Сколько чисел вы хотите ввести?: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Fillrray(array);
WriteArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество положительных чисел {count}");