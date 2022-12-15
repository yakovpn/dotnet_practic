using DotNetPractic;
public partial class lesson008
{
    // Задача 1: Задайте двумерный массив. Напишите программу,
    // которая поменяет местами первую и последнюю строку
    // массива.
    public void exampleBody1()
    {
        int[,] arr = new int[12, 10];
        arr = DNPTools.FillIntMatrix(arr, 1, 99);
        DNPTools.PrintArr(arr);
        Console.WriteLine("Меняем первую и последнюю строку");
        for (int c = 0; c < 10; c++)
            (arr[0, c], arr[11, c]) = (arr[11, c], arr[0, c]);
        DNPTools.PrintArr(arr);
    }
    // Задача 2: Задайте двумерный массив. Напишите программу,
    // которая заменяет строки на столбцы. В случае, если это
    // невозможно, программа должна вывести сообщение для
    // пользователя.
    public void exampleBody2()
    {
        int m = DNPTools.ReadInt("Введите m:", true, 1);
        int n = DNPTools.ReadInt("Введите n:", true, m, m);
        int[,] arr = new int[m, n];
        int[,] arr2 = new int[m, n];
        arr = DNPTools.FillIntMatrix(arr, 1, 99);
        DNPTools.PrintArr(arr);
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                arr2[j, i] = arr[i, j];
        DNPTools.PrintArr(arr2);


    }
    // Задача 3: Составить частотный словарь элементов
    // двумерного массива. Частотный словарь содержит
    // информацию о том, сколько раз встречается элемент
    // входных данных. Значения элементов массива 0..9
    public void exampleBody3()
    {
        int[,] arr = new int[12, 10];
        arr = DNPTools.FillIntMatrix(arr, 0, 9);
        int[] freqArr = new int[10];
        DNPTools.PrintArr(arr);
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                freqArr[arr[i, j]]++;
        DNPTools.PrintArr(freqArr);


    }
    // Задача 4: Задайте двумерный массив из целых чисел.
    // Напишите программу, которая удалит строку и столбец, на
    // пересечении которых расположен наименьший элемент
    // массива.
    public void exampleBody4()
    {
        int[,] arr = new int[4, 4];
        arr = DNPTools.FillIntMatrix(arr, 0, 9);
        DNPTools.PrintArr(arr);
        (int, int) minIndex = (0, 0);
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                if (arr[minIndex.Item1, minIndex.Item2] > arr[i, j]) minIndex = (i, j);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i == minIndex.Item1 | j == minIndex.Item2) continue;
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    // Задача 5: Вывести первые N строк треугольника
    // Паскаля. Сделать вывод в виде равнобедренного
    // треугольника
    public double factorial(int n)
    {
        double i, x = 1;
        for (i = 1; i <= n; i++)
        {
            x *= i;
        }
        return x;
    }
    public void exampleBody5()
    {
        int n = DNPTools.ReadInt("Введите n:", true, 1, 20);
        for (int i = 0; i < n; i++)
        {
            for (int c = 0; c <= (n - i); c++)
            {
                Console.Write(" ");
            }
            for (int c = 0; c <= i; c++)
            {
                Console.Write(" ");
                Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
