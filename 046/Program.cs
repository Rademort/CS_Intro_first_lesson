// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


int[] arr = new int[123];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(0, 11);
    //Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();

int countNumbers = 0;
for (int i = arr.Length - 113; i <= arr.Length - 24; i++)
{
    countNumbers++;
}
System.Console.WriteLine($"Количество элементов массива из отрезка [10,99] равно {countNumbers}");