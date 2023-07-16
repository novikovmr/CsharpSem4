/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

int[] Generate(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void Print(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение для диапазона случайного числа: ");
int min= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение для диапазона случайного числа: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = Generate(length, min, max);
Print(array);
