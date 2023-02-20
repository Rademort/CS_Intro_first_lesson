﻿// Пузырьковая сортировка, bubbleSort
int[] RandomIntArray(int N, int min, int max)
{

    int[] a = new int[N];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(min, max + 1);
    }
    return a;
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i],5}");
    }
}


void BubbleSort(int[] a)
{
    for (int j = 0; j < a.Length; j++)
    {
        for (int i = 0; i < a.Length - 1 - j; i++)
        {
            if (a[i] > a[i + 1])
            {
                int t = a[i];
                a[i] = a[i + 1];
                a[i + 1] = t;
            }
        }
    }
}
// SelectSort

void SelectSort(int[] a)
{
    for (int j = 0; j < a.Length; j++)
    {
        int indexM = j;
        for (int i = j + 1; i < a.Length; i++)
        {
            if (a[i] < a[indexM])
            {
                indexM = i;
            }
        }
        int t = a[j];
        a[j] = a[indexM];
        a[indexM] = t;
    }
}

//int find = 20;

int[] arr = RandomIntArray(20, 0, 100);
PrintArray(arr);

SelectSort(arr);
System.Console.WriteLine();
PrintArray(arr);
System.Console.WriteLine();

