using DotNetPractic;
public partial class lesson009
{
    // Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
    // все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
    // M = 1; N = 5 -> "2, 4"
    // M = 4; N = 8 -> "4, 6, 8"    
    private void writeEvenInRange(int a, int b)
    {
        if (a > b) return;
        if (a % 2 == 0) Console.Write($"{a}");
        int step = (a % 2 == 0 ? 2 : 1);
        if (a + 1 < b) Console.Write(" ");
        else Console.WriteLine();
        writeEvenInRange(a + step, b);
    }
    public void homeWorkBody1()
    {
        int m = DNPTools.ReadInt("Введите M:", true, int.MinValue);
        int n = DNPTools.ReadInt("Введите N:", true, m);
        Console.Write($"все четные числа между {m} и {n}: ");
        writeEvenInRange(m, n);
    }
    // Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
    // в промежутке от M до N с помощью рекурсии.
    // M = 1; N = 15 -> 120 M = 4; N = 8 -> 30 
    public int getSumDigitsInRange(int a, int b, int digSum = 0)
    {
        if (a == b) return digSum + a;
        return getSumDigitsInRange(a + 1, b, digSum + a);
    }
    public void homeWorkBody2()
    {
        int m = DNPTools.ReadInt("Введите M:", true, int.MinValue);
        int n = DNPTools.ReadInt("Введите N:", true, m);
        Console.WriteLine($"сумма натуральных элементов в промежтке между {m} и {n} = {getSumDigitsInRange(m, n)}");

    }
}