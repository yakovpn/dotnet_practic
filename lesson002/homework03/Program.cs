// Задача 3:
// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadNumber()
{
    Console.Write("Введите число:");
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int a = ReadNumber();
if (a < 100)
{
    Console.WriteLine("Третьего числа нет");
}
else
{
    Console.WriteLine($"Вариант №1:{a.ToString()[2]}");

    int digitCount = (int)Math.Log10(a) + 1;
    int divider = 1;
    while (digitCount > 3)
    {
        divider *= 10;
        digitCount--;
    }
    Console.WriteLine($"Вариант №2:{a / divider % 10}");
    int b = a;
    divider = 1;
    while (b > 999)
    {
        divider *= 10;
        b /= 10;

    }
    Console.WriteLine($"Вариант №3:{a / divider % 10}");
}
