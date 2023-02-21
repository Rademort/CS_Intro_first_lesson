// Найти сумму цифр числа

int SumLoop(int N)
{
    if (N == 0)
    {
        return 0;
    }
    else
    {
        if (N < 10)
        {
            return N;
        }
        else
        {
            return SumLoop(N / 10) + SumLoop(N % 10);
        }
    }
}



System.Console.WriteLine(SumLoop(123));