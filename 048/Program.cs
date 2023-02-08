// Задан массив a из N элементов. Заполнить массив случайными числами 
// от 1 до 10. Создайте массив, который является произведением пар чисел 
// в одномерном массиве a. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д.
System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int[] arr = new int[N];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(0, 11);
    Console.Write($"{arr[i]} ");
}

int mult = 0;
int[] arr2 = new int[arr.Length / 2];
for (int i = 0; i < arr.Length / 2; i++)
{
    mult = arr[i] * arr[(arr.Length - 1) - i];
    arr2[i] = mult;
}
System.Console.WriteLine();
string s = String.Join(", ", arr2);
System.Console.WriteLine(s);