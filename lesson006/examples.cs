using DotNetPractic;
public partial class lesson006
{
    // Задача 1: Напишите программу, которая принимает на вход три
    // числа и проверяет, может ли существовать треугольник с сторонами
    // такой длины.
    // Теорема о неравенстве треугольника: каждая сторона треугольника
    // меньше суммы двух других сторон.
    public void exampleBody1()
    {
        int a = DNPTools.ReadInt("Введите первое число:");
        int b = DNPTools.ReadInt("Введите второе число:");
        int c = DNPTools.ReadInt("Введите третье число:");
        if (a < b + c && b < a + c && c < a + b) Console.WriteLine("С такими сторонами может существовать треугольник");
        else Console.WriteLine("С такими сторонами существовать треугольник НЕ может");
    }
    // Задача 2: Напишите программу, которая будет преобразовывать
    // десятичное число в двоичное.
    // 45 -> 101101
    // 3 -> 11
    // 2 -> 10
    public Int128 DecimalToBin(int decimalNumber)
    {
        if (decimalNumber == 0) return 0;
        return decimalNumber % 2 + 10 * (DecimalToBin(decimalNumber / 2));
    }
    string DecimalToBinStr(int n)
    {
        string result = "";
        while (n > 0)
        {
            result = n % 2 + result;
            n /= 2;
        }
        return result;
    }
    public void exampleBody2()
    {
        int decimalNumber = DNPTools.ReadInt("Введите число в десятичном формате:");
        Console.WriteLine($"Число  {decimalNumber} в двоичном формате V1: {DecimalToBin(decimalNumber)}");
        Console.WriteLine($"Число  {decimalNumber} в двоичном формате V2: {DecimalToBinStr(decimalNumber)}");
    }
    // Задача 3: Не используя рекурсию, выведите первые N чисел
    // Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
    // Если N = 5 -> 0 1 1 2 3
    // Если N = 3 -> 0 1 1
    // Если N = 7 -> 0 1 1 2 3 5 8
    double FibonacciRecursion(int n)
    {
        if (n == 0) return 0;
        if (n == 1 || n == 2) return 1;
        else return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
    }
    void FibonacciCortage(int num)
    {
        int a = 0;
        int b = 1;
        for (int i = 0; i < num; i++)
        {
            Console.Write($"{a} ");
            (a, b) = (b, a + b);
        }
    }
    public void exampleBody3()
    {
        int N = DNPTools.ReadInt("Введите число N (>0):", true, 1);

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"f({i}) = {FibonacciRecursion(i)}");
        }
        FibonacciCortage(N);

    }
    // Задача 4: Напишите программу, которая будет создавать
    // копию заданного массива с помощью поэлементного
    // копирования. 

    int[,] copyArray(int[,] srcArr)
    {
        int numRows = srcArr.GetLength(0);
        int numColumns = srcArr.GetLength(1);
        int[,] dstArr = new int[numRows, numColumns];
        for (int r = 0; r < numRows; r++)
        {
            for (int c = 0; c < numColumns; c++)
            {
                dstArr[r, c] = srcArr[r, c];
            }
        }
        return dstArr;
    }
    public void exampleBody4()
    {
        int numRows = DNPTools.ReadInt("Введите количество строк (>0):", true, 1);
        int numColumns = DNPTools.ReadInt("Введите количество колонок (>0):", true, 1);
        int[,] arr = DNPTools.FillIntMatrix(new int[numRows, numColumns], 0, 99);
        DNPTools.PrintArr(arr);
        int[,] newArr = new int[numRows, numColumns];
        newArr = copyArray(arr);
        Console.WriteLine($"Массив скопирован в другой: {DNPTools.ArrToStr(newArr)}");

    }
}
