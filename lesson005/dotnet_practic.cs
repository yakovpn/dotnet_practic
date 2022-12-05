namespace DotNetPractic;
public class DNPTools
{
    /// <summary>
    /// Read text from user input
    /// </summary>
    /// <remarks>
    /// This method read text from user input, verify and return int value.
    /// </remarks>
    /// <returns>
    ///  Int32 parsed text value
    /// </returns>
    /// <param name="message">
    /// user prompt message
    /// </param>
    /// <param name="filterEnable">
    /// on/off verify user input
    /// </param>
    /// <param name="minValue">
    /// minimal integer value (default:0)
    /// </param>
    /// <param name="maxValue">
    /// maximal integer value (default:999999999)
    /// </param>
    public static int ReadInt(string message, bool filterEnable = false, int minValue = 0, int maxValue = Int32.MaxValue)
    {
        Console.Write(message);
        var s = Console.ReadLine();
        int a = s == null ? 0 : int.Parse(s);
        if (filterEnable)
        {
            if (a < minValue || a > maxValue)
            {
                Console.WriteLine("Ошибка ввода");
                Environment.Exit(-1);
            }
        }
        return a;
    }
    /// <summary>
    /// Print Int32 array to console
    /// </summary>
    /// <remarks>
    /// This method foreach array and print values in formatted string to console
    /// </remarks>
    /// <param name="arrayToPrint">
    /// Int32 array
    public static void PrintArr(Array arrayToPrint)
    {
        string arrStr = string.Empty;
        for (int i = 0; i < arrayToPrint.Length; i++) arrStr += $"{arrayToPrint.GetValue(i)} ";
        arrStr = arrStr.Substring(0, arrStr.Length - 1);
        Console.WriteLine(arrStr);
    }
    /// <summary>
    /// Convert Int32[] array to string
    /// </summary>
    /// <remarks>
    /// This method foreach array and return formatted string
    /// </remarks>
    /// <param name="arrayToPrint">
    /// Int32 array
    public static string ArrToStr(Array arrayToPrint)
    {
        string arrStr = string.Empty;
        for (int i = 0; i < arrayToPrint.Length; i++) arrStr += $"{arrayToPrint.GetValue(i)} ";
        return arrStr.Substring(0, arrStr.Length - 1);
    }
    /// <summary>
    /// Fill array random values
    /// </summary>
    /// <returns>
    ///  Int32[] filled array
    /// </returns>
    /// <param name="arrayToFill">
    /// Int32 array
    /// </param>
    /// <param name="minValue">
    /// minimal integer array value
    /// </param>
    /// <param name="maxValue">
    /// maximal integer array value
    /// </param>
    public static int[] FillIntArr(int[] arrayToFill, int minValue, int maxValue)
    {
        for (int i = 0; i < arrayToFill.Length; i++) arrayToFill[i] = new Random().Next(minValue, maxValue + 1);
        return arrayToFill;
    }
    /// <summary>
    /// Fill array random values
    /// </summary>
    /// <returns>
    ///  Double[] filled array
    /// </returns>
    /// <param name="arrayToFill">
    /// Double array
    /// </param>
    /// <param name="minValue">
    /// minimal double array value
    /// </param>
    /// <param name="maxValue">
    /// maximal double array value
    /// </param>
    public static double[] FillDoubleArray(double[] arrayToFill, double minValue, double maxValue)
    {
        for (int i = 0; i < arrayToFill.Length; i++) arrayToFill[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        return arrayToFill;

    }

}
