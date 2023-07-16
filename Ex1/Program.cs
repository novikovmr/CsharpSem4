/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

int f(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;  
    }
    return res;
}
Console.Write("Введите первое число: ");
int firstNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(f(firstNumb, secondNumb));