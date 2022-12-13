using DotNetPractic;
public partial class lesson007
{

    ///<summary>
    /// Домашнее задание №1
    ///</summary>
    ///<remark>
    /// Задача 1: Задайте двумерный массив размером m×n,
    /// заполненный случайными вещественными числами.
    /// m = 3, n = 4.
    /// 0,5 7 -2 -0,2
    /// 1 -3,3 8 -9,9
    /// 8 7,8 -7,1 9
    ///</remark>
    public void homeWorkBody1()
    {
        int m = DNPTools.ReadInt("Введите m:", true, 1);
        int n = DNPTools.ReadInt("Введите n:", true, 1);
        double[,] arr = new double[m, n];
        arr = DNPTools.FillDoubleMatrix(arr, -99, 99);
        DNPTools.PrintArr(arr);

    }
    ///<summary>
    ///Домашнее задание №2
    ///</summary>
    ///<remark>
    /// Задача 2: Напишите программу, которая на вход
    /// принимает позиции элемента в двумерном массиве, и
    /// возвращает значение этого элемента или же указание,
    /// что такого элемента нет.
    /// Например, задан массив:
    /// 1 4 7 2
    /// 5 9 2 3
    /// 8 4 2 4
    /// 1 7 -> такого числа в массиве нет
    ///<remark>
    public void homeWorkBody2()
    {
        int[,] arr = new int[9, 8];
        arr = DNPTools.FillIntMatrix(arr, 0, 99);
        DNPTools.PrintArr(arr);

        int row = DNPTools.ReadInt("Введите номер строки:", true, 1);
        int column = DNPTools.ReadInt("Введите номер колонки:", true, 1);
        // Если надо то можно проверить на входе сразу через метод запроса ввода:
        // int row = DNPTools.ReadInt("Введите номер строки:", true, 1,9);
        // int column = DNPTools.ReadInt("Введите номер колонки:", true, 1,8);

        // А можно через exception:
        try
        {
            Console.WriteLine(arr[row - 1, column - 1]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            if (e.Message == "Index was outside the bounds of the array.")
                Console.WriteLine("такого элемента нет");
        }
    }
    ///<summary>
    ///Домашнее задание №3
    ///</summary>
    ///<remark>
    /// Задача 3: Задайте двумерный массив из целых чисел.
    /// Найдите среднее арифметическое элементов в каждом
    /// столбце.
    /// Например, задан массив:
    /// 1 4 7 2
    /// 5 9 2 3
    /// 8 4 2 4
    /// Среднее арифметическое каждого
    /// столбца: 4,6; 5,6; 3,6; 3.
    ///<remark>
    public void homeWorkBody3()
    {
        int m = DNPTools.ReadInt("Введите m:", true, 1);
        int n = DNPTools.ReadInt("Введите n:", true, 1);
        int[,] arr = new int[m, n];
        int[] avgSum = new int[n];
        arr = DNPTools.FillIntMatrix(arr, 1, 99);
        DNPTools.PrintArr(arr);
        for (int j = 0; j < n; j++)
        {
            avgSum[j] = 0;
            for (int i = 0; i < m; i++) avgSum[j] += arr[i, j];
            avgSum[j] /= m;

        }
        Console.Write("Среднее арифмитичекое сталобцов:");
        DNPTools.PrintArr(avgSum);
    }
}