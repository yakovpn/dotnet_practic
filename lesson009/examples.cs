using DotNetPractic;
public partial class lesson009
{

    // Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
    // N = 5 -> "1, 2, 3, 4, 5"
    // N = 6 -> "1, 2, 3, 4, 5, 6"
    private void PrintDigInNum(int start, int end)
    {
        if (start == end) Console.WriteLine($"{end}");
        else
        {
            Console.Write($"{start} ");
            PrintDigInNum(start + 1, end);
        }
    }
    public void exampleBody1()
    {
        int n = DNPTools.ReadInt("Введите Т:", true, 1, int.MaxValue);
        PrintDigInNum(1, n);
    }
    // Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
    //  M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"
    public void exampleBody2()
    {
        int m = DNPTools.ReadInt("Введите M:", true, 1, int.MaxValue);
        int n = DNPTools.ReadInt("Введите N:", true, m, int.MaxValue);
        PrintDigInNum(m, n);
    }
    // Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
    // 453 -> 12 45 -> 9
    private int GetSumDigInNum(int n, int curSumm = 0)
    {
        if (n < 10) return curSumm + n;
        return GetSumDigInNum(n / 10, curSumm + (n % 10));
    }
    public void exampleBody3()
    {
        int m = DNPTools.ReadInt("Введите число:", true);
        Console.WriteLine(GetSumDigInNum(m).ToString());
    }
    // Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
    //  A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8
    private double MyPow(double a, int degree)
    {
        if (degree <= 1) return a;
        return (a * MyPow(a, degree - 1));
    }
    public void exampleBody4()
    {
        int a = DNPTools.ReadInt("Введите A:", true);
        int b = DNPTools.ReadInt("Введите B:", true);
        Console.WriteLine($"{a} в сетпени {b} = {Math.Round(MyPow(a, b), 0)}");
    }
}
