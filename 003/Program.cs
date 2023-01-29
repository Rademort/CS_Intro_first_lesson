// С клавиатуры вводятся два числа a и b. Найти максимальное из них.

int a, b, max;

System.Console.WriteLine("Введите число a: ");
a = b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b: ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
System.Console.WriteLine($"max={max}");