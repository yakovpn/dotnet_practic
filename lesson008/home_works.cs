using DotNetPractic;
public partial class lesson008
{

    // Задача 1: Задайте двумерный массив. Напишите программу, которая
    // упорядочит по убыванию элементы каждой строки двумерного массива.
    public int[,] sortDescOneRowMatrix(int[,] arr, int rowIndex)
    {
        for (int i = 0; i < arr.GetLength(1) - 1; i++)
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
                if (arr[rowIndex, j] < arr[rowIndex, j + 1])
                    (arr[rowIndex, j], arr[rowIndex, j + 1]) = (arr[rowIndex, j + 1], arr[rowIndex, j]);
        return arr;
    }
    public void homeWorkBody1()
    {
        int m = DNPTools.ReadInt("Введите количество строк:", true, 1);
        int n = DNPTools.ReadInt("Введите количество колонок:", true, 1);
        int[,] arr = DNPTools.FillIntMatrix(new int[m, n], 0, 9);
        DNPTools.PrintArr(arr);
        Console.WriteLine("После сортировки строк матрица будет выглядеть так:");
        for (int i = 0; i < m; i++)
        {
            arr = sortDescOneRowMatrix(arr, i);
        }
        DNPTools.PrintArr(arr);
    }
    // Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
    // которая будет находить строку с наименьшей суммой элементов.
    public void homeWorkBody2()
    {
        int m = DNPTools.ReadInt("Введите количество строк:", true, 1);
        int n = DNPTools.ReadInt("Введите количество колонок:", true, 1);
        int[,] arr = DNPTools.FillIntMatrix(new int[m, n], 0, 9);
        DNPTools.PrintArr(arr);
        int minRowIndex = 0;
        double minSumm = double.MaxValue;
        for (int i = 0; i < m; i++)
        {
            int minSummNew = 0;
            for (int j = 0; j < n; j++) minSummNew += arr[i, j];
            if (minSumm > minSummNew)
            {
                minSumm = minSummNew;
                minRowIndex = i;
            }
        }
        Console.WriteLine($"Строка с номером {minRowIndex + 1} содержит наименьшую сумму элементов");
    }
    // Задача 3: Задайте две матрицы. Напишите программу, которая будет
    // находить произведение двух матриц.
    public int[,] MultiplicateMatrix(int[,] arr1, int[,] arr2)
    {
        if (arr1.GetLength(1) != arr2.GetLength(0)) throw new Exception("multiplicate matrix failed");
        int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr2.GetLength(0); k++)
                {
                    arr3[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
        return arr3;
    }
    public void homeWorkBody3()
    {
        int m1 = DNPTools.ReadInt("Введите количество строк первой матрицы:", true, 1);
        int n1 = DNPTools.ReadInt("Введите количество колонок первой матрицы:", true, 1);
        int m2 = DNPTools.ReadInt("Введите количество строк второй матрицы:", true, 1);
        int n2 = DNPTools.ReadInt("Введите количество колонок второй матрицы:", true, 1);
        int[,] arr1 = DNPTools.FillIntMatrix(new int[n1, m1], 0, 9);
        int[,] arr2 = DNPTools.FillIntMatrix(new int[n2, m2], 0, 9);
        DNPTools.PrintArr(arr1);
        Console.WriteLine();
        DNPTools.PrintArr(arr2);
        Console.WriteLine("Результат перемножения двух матриц:");
        try
        {
            int[,] arr3 = MultiplicateMatrix(arr1, arr2);
            DNPTools.PrintArr(arr3);
        }
        catch (Exception e)
        {
            if (e.Message == "multiplicate matrix failed") Console.WriteLine("Матрицы нельзя перемножать");
        }
    }
}