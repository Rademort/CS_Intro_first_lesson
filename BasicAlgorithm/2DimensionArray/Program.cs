// Двухмерный массив

// int[,] a = new int[4, 3]{{1,2,3},
//                         {1,2,3},
//                         {1,2,3},
//                         {1,2,3}};



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

bool FindElementIn2DArray(int[,] a, int find, out int row, out int column)
{
    row = -1;
    column = -1;
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            if (a[i, j] == find)
            {
                row = i;
                column = j;
                return true;
            }
    return false;
}

int[,] a = Random2dArray(3, 4, 10, 0);
Print2dArray(a);
int r,c;
if (FindElementIn2DArray(a,10,out r,out c))
  System.Console.WriteLine($"row={r} column={c}");
else
  System.Console.WriteLine("Element not found");




// Трехмерный массив

// int[,,] a3 = new int[4, 3, 3];
// for (int k = 0; k < a3.GetLength(2); k++)
// {
//     for (int i = 0; i < a3.GetLength(0); i++)
//     {
//         for (int j = 0; j < a3.GetLength(1); j++)
//         {
//             a3[i, j, k] = k * 100 + i * 10 + j;
//         }
//     }
// }

// for (int k = 0; k < a3.GetLength(2); k++)
// {
//     System.Console.WriteLine(k);
//     for (int i = 0; i < a3.GetLength(0); i++)
//     {
//         for (int j = 0; j < a3.GetLength(1); j++)
//         {
//             System.Console.Write($"{a3[i, j, k],5}");
//         }
//         System.Console.WriteLine();
//     }
// }


