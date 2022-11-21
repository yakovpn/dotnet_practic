Console.Write("Введите число:");
var s = Console.ReadLine();
int N = s == null ? 0 : int.Parse(s);
int negN = - N;

while (negN < N) {
    Console.Write($"{negN} ");
    negN +=1;
}