// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] arr = new int [10];
Random random=new Random();
int countEven = 0;
int countOdd = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(100, 1000);
    Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();
for (int j = 0; j < arr.Length; j++)
{
    if(arr[j]%2==0){
        countEven++;
    }else
    {
        countOdd++;
    }
}
System.Console.WriteLine($"В массиве четных чисел: {countEven}, а нечетных чисел: {countOdd}");