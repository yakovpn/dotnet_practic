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
    //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    private Array fillTwoNum3dMatrixUnique(Array arr, int minValue, int maxValue)
    {
        int valuesRange = maxValue - minValue;
        if (arr.Rank != 3) throw new Exception("Массив не трехмерный!");
        if (arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2) > maxValue - minValue)
            throw new Exception("Не хватит диапазона значений для заполнения такой 3d матрицы");
        for (int x = 0; x < arr.GetLength(0); x++)
            for (int y = 0; y < arr.GetLength(1); y++)
                for (int z = 0; z < arr.GetLength(2); z++)
                    while (true)
                    {
                        int newVal = new Random().Next(minValue, maxValue);
                        bool valueInArr = false;
                        foreach (int item in arr)
                            if (item == newVal) { valueInArr = true; break; }
                        if (!valueInArr)
                        {
                            arr.SetValue(newVal, x, y, z);
                            break;
                        }
                    }
        return arr;
    }
    private void print3dMatrixWithIndex(Array arr)
    {
        for (int x = 0; x < arr.GetLength(0); x++)
            for (int y = 0; y < arr.GetLength(1); y++)
            {
                for (int z = 0; z < arr.GetLength(2); z++)
                    Console.Write($" {arr.GetValue(x, y, z)} ({x},{y},{z}) ");
                Console.WriteLine();
            }

    }

    public void homeWorkBody4()
    {
        int x = DNPTools.ReadInt("Введите количество строк:", true, 1, 89);
        int y = DNPTools.ReadInt("Введите количество колонок:", true, 1, 89);
        int z = DNPTools.ReadInt("Введите глубину:", true, 1, 89);
        try
        {
            Array arr = fillTwoNum3dMatrixUnique(new int[x, y, z], 10, 99);
            print3dMatrixWithIndex(arr);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
    //Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    public void homeWorkBody5()
    {
        int m = DNPTools.ReadInt("Введите m:", true, 1);
        int[,] arr = new int[m, m];
        int x = 0, y = 0, size = m, count = 1;

        while (size > 0)
        {
            for (int i = y; i <= y + size - 1; i++)
                arr[x, i] = count++;
            for (int j = x + 1; j <= x + size - 1; j++)
                arr[j, y + size - 1] = count++;
            for (int i = y + size - 2; i >= y; i--)
                arr[x + size - 1, i] = count++;
            for (int i = x + size - 2; i >= x + 1; i--)
                arr[i, y] = count++;
            x = x + 1;
            y = y + 1;
            size = size - 2;
        }
        DNPTools.PrintArr(arr);

    }
}