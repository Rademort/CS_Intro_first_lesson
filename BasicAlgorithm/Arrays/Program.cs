// Подсчитать среднюю температуру 

int y=0;
System.Console.WriteLine(y);
//инициализация переменных
double[] temps;
temps=new double[7];
//ввод данных
for(int i=0;i<temps.Length;i++)
   temps[i]=Convert.ToDouble(Console.ReadLine());
//решение задачи
//находим сумму массива
double s=0;
for(int i=0;i<temps.Length;i++)
    s=s+temps[i];
//вывод результата
System.Console.WriteLine(s/temps.Length);