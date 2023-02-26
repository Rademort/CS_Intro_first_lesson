//  Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int[,] Random2dArray(int N, int M, int max, int min)
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

int[,] arr1 = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
int[,] arr2 = { { 4, 5, 6 }, { 4, 5, 6 }, { 4, 5, 6 } };
int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];


void MultArraysElements(int[,] a, int[,] b, int[,] result)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            result[i, j] = a[i, j] * b[i, j];
        }
    }
}

Print2dArray(arr1);
System.Console.WriteLine();
Print2dArray(arr2);
System.Console.WriteLine();
MultArraysElements(arr1, arr2, result);
Print2dArray(result);