// Посчитать сумму цифр в числе

int SumDigits(int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum = sum + N % 10;
        N /= 10;
    }
    return sum;
}
System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в числе {N} равна: {SumDigits(N)}");