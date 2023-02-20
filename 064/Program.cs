// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

int[,] Random2dArray(int N, int M, int min, int max)
{
    int[,] a = new int[N, M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(min, max + 1);
        }
    }
    return a;
}

void Print2dArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i, j],7}");
        }
        System.Console.WriteLine();
    }
}

int[,] ChangeToSquareArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                a[i, j] = a[i, j] * a[i, j];
            }
        }

    }
    return a;
}

int[,] array = Random2dArray(5, 4, 0, 100);
Print2dArray(array);
System.Console.WriteLine();
ChangeToSquareArray(array);
Print2dArray(array);