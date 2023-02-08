//40. Задать массив из 8 целых элементов и вывести их на экран
int[] arr;
arr=new int[8];
Random random=new Random();//Описание и создание объект
for(int i=0;i<arr.Length;i++)
    arr[i]=random.Next(0,10);

for(int i=0;i<arr.Length;i++)
    System.Console.Write($"{arr[i]} ");
System.Console.WriteLine();    