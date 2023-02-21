// Показать натуральные числа от N до 1, N задано

void Loop(int i, int N)
{
    System.Console.Write($"{N,4}");
    if (N > i) Loop(i, N - 1);
}
Loop(1, 10);