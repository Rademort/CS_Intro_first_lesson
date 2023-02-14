// Написать программу копирования массива
int[] arr1 = { 1, 2, 3, 4 };
int[] arr2 = new int[arr1.Length];

CoppyArray(arr1, ref arr2);
PrintArray(arr2);

void CoppyArray(int[] a1, ref int[] a2) // вроде как есть уже готовые методы для любых типов массивов. Но я так только придумал
{
    for (int i = 0; i < arr1.Length; i++)
    {
        a2[i] = a1[i];
    }
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i]} ");
    }
}