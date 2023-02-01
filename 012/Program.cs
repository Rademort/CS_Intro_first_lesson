// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
System.Console.Write("Введите число от 10 до 99: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 10 & N <= 99)
{
    int d0 = N % 10;
    int d1 = N / 10 % 10;
    int max = d0;
    if (d1 > max)
    {
        max = d1;
        System.Console.WriteLine("Наибольшая цифра числа: " + max);
    }
    else { System.Console.WriteLine("Наибольшая цифра числа: " + max); }
}
else
{
    System.Console.WriteLine("Введенное число не соответствует диапазону от 10 до 99");
}