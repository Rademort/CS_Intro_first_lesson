// Показать двумерный массив размером m×n заполненный целыми случайными числами

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
            System.Console.Write($"{a[i, j],5}");
        }
        System.Console.WriteLine();
    }
}


int[,] arr = Random2dArray(5, 6, 0, 100);
Print2dArray(arr);