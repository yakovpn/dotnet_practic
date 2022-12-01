//Задача 27: Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int ReadInt(string message, bool filterEnable = false, int minRange = 0, int maxRange = 999999999)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    if (filterEnable)
    {
        if (a < minRange || a > maxRange)
        {
            Console.WriteLine("Ошибка ввода");
            Environment.Exit(-1);
        }
    }
    return a;
}
int n = ReadInt("Введите число:", true, -999999999);
n = Math.Abs(n);
int digitSumm = 0;
if (n == 0) Console.WriteLine($"В сумма чисел в числе {n} равна 0");
else
{
    while (n > 0)
    {
        digitSumm += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе {n} равна {digitSumm}");
}
