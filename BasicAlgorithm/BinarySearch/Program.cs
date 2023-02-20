// Бинарный поиск

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

int BinarySearch(int[] arr, int find)
{
    int i;
    int left = 0;
    int rigth = arr.Length - 1;
    i = left + ((rigth - left) / 2);
    while (arr[i] != find && left < rigth)
    {
        if (find > arr[i])
        {
            left = i + 1;
        }
        else
        {
            rigth = i;
        }
        i = left + ((rigth - left) / 2);
    }
    if (arr[i] != find)
    {
        return -1;
    }
    else
    {
        return i;
    }
}

int find = 20;

int[] arr = RandomIntArray(20, 0, 100);
PrintArray(arr);
Array.Sort(arr);
System.Console.WriteLine();
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine(BinarySearch(arr, find));

