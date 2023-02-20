// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] Random2DArray(int N, int M, int min, int max)
{
    int[,] a = new int[N, M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],6}");
        System.Console.WriteLine();
    }
}

void Swap(ref int a, ref int b)
{
    int t = a;
    a = b;
    b = t;
}

int[,] ChangeRows2dArray(int[,] a, int row1, int row2)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Swap(ref a[row1, j], ref a[row2, j]);

    }

    return a;
}

int[,] array = Random2DArray(3, 4, 0, 10);
Print2DArray(array);
System.Console.WriteLine();
ChangeRows2dArray(array,0,2);
Print2DArray(array);