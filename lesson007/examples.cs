using DotNetPractic;
public partial class lesson007
{
    // Задача 1: Задайте двумерный массив размера m на n, каждый
    // элемент в массиве находится по формуле: Aₙₙ = m+n.
    // Выведите полученный массив на экран.
    // m = 3, n = 4.
    // 0 1 2 3
    // 1 2 3 4
    // 2 3 4 5
    public void exampleBody1()
    {
        int m = DNPTools.ReadInt("Введите m:", true, 1);
        int n = DNPTools.ReadInt("Введите n:", true, 1);
        int[,] arr = new int[m, n];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                arr[i, j] = i + j;
        DNPTools.PrintArr(arr);
    }
    // Задача 2: Задайте двумерный массив. Найдите элементы, у которых
    // обе позиции чётные, и замените эти элементы на их квадраты.
    public void exampleBody2()
    {
        int m = DNPTools.ReadInt("Введите m:", true, 1);
        int n = DNPTools.ReadInt("Введите n:", true, 1);
        int[,] arr = new int[m, n];
        arr = DNPTools.FillIntMatrix(arr, 1, 99);
        DNPTools.PrintArr(arr);
        Console.WriteLine("Изменили элементы на четных позициях");
        for (int i = 1; i < m; i += 2)
            for (int j = 1; j < n; j += 2)
                arr[i, j] = ((int)Math.Pow(arr[i, j], 2));
        DNPTools.PrintArr(arr);
    }
    // Задача 3: Задайте двумерный !квадратный! массив. Найдите сумму элементов
    // главной диагонали.
    public void exampleBody3()
    {
        int m = DNPTools.ReadInt("Введите длинну квадратной матрицы:", true, 1);
        int[,] arr = new int[m, m];
        arr = DNPTools.FillIntMatrix(arr, 1, 99);
        int summ = 0;
        for (int i = 0; i < m; i++) summ += arr[i, i];

    }
    // Задача 4: Задайте двумерный массив. Введите элемент, и найдите
    // первое его вхождение, выведите позиции по горизонтали и
    // вертикали, или напишите, что такого элемента нет.
    public void exampleBody4()
    {
        int m = DNPTools.ReadInt("Введите m:", true, 1);
        int n = DNPTools.ReadInt("Введите n:", true, 1);
        int[,] arr = new int[m, n];
        arr = DNPTools.FillIntMatrix(arr, 1, 99);
        DNPTools.PrintArr(arr);
        int searchValue = DNPTools.ReadInt("Введите икомое значение:");
        bool foundValue = false;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (arr[i, j] == searchValue)
                {
                    Console.WriteLine($"Найден элемент с индексом [{i},{j}]");
                    foundValue = true;
                }
        if (!foundValue) Console.WriteLine("Элемент не найден");
    }
}
