//42. Задать массив из 12 элементов, заполненных числами из [-9, 9].
// Найти сумму положительных/отрицательных элементов массива

int[] arr=new int[3];
Random random=new Random();
for(int i=0;i<arr.Length;i++)
    arr[i]=random.Next(-9,10);

for(int i=0;i<arr.Length;i++)
    System.Console.Write($"{arr[i]} ");
System.Console.WriteLine();
int sumPositive=0;
for(int i=0;i<arr.Length;i++)
    if (arr[i]>0)
        sumPositive=sumPositive+arr[i];

int sumNegative=0;
for(int i=0;i<arr.Length;i++)
    if (arr[i]<0)
        sumNegative=sumNegative+arr[i];
System.Console.WriteLine($"Sum of positive numbers:{sumPositive}");        
System.Console.WriteLine($"Sum of negative numbers:{sumNegative}");        