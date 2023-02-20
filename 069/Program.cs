// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


void Sort(int[,] a)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int i = 0; i < a.GetLength(0) - 1; i++)
        {
            if (a[i, j] > a[i + 1, j])
            {
                int t = a[i, j];
                a[i, j] = a[i + 1, j];
                a[i + 1, j] = t;
            }
        }
    }
}



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

int[,] array = Random2DArray(3, 4, 0, 10);
Print2DArray(array);
System.Console.WriteLine();
Sort(array);
Print2DArray(array);