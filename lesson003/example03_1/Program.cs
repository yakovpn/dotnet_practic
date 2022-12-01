int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void Range(int quarterNum)
{

}

int quarterNum = ReadNumber("Введите номер четверти:");
Range(quarterNum);