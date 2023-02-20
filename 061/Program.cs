// Показать двумерный массив размером m×n заполненный вещественными случайными числами

void PrintDouble2dArray(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i, j],8:F3}");
        }
        System.Console.WriteLine();
    }
}

double[,] RandomDouble2dArray(int N, int M)
{
    double[,] a = new double[N, M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.NextDouble() * 100;
        }
    }
    return a;
}

double[,] array = RandomDouble2dArray(3, 4);
PrintDouble2dArray(array);