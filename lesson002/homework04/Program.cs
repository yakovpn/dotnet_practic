// Задача 4:
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadDayOfWeek()
{
    Console.Write("Введите день недели:");
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return (a > 1 && a < 8) ? a : -1;
}
int a = ReadDayOfWeek();
if (a < 0)
{
    Console.WriteLine("Ошибка ввода");
}
else if (a < 6)
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Выходной день");
}
