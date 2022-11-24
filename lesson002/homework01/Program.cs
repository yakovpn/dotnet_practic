// Задача 1:
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadNumber()
{
    Console.Write("Введите трехзначное число:");
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return (a > 99 && a < 1000) ? a : -1;
}
int a = ReadNumber();
if (a < 0)
{
    Console.WriteLine("Ошибка ввода");
    return;
}
Console.Write("Вариант №1:");
Console.WriteLine(a.ToString()[1]);

Console.Write("Вариант №2:");
Console.WriteLine(a / 10 % 10);