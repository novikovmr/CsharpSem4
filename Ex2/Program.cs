/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/

Console.Clear();

int f(int x)
{
    int res = 0;
    while (x > 0)
    {
        res = res + x % 10;
        x /= 10;
    }
    return res;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(number));

