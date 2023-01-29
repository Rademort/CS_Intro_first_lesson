// Вводятся два числа. Найти и вывести на экран их суммую

int a, b, sum;
System.Console.Write("Введите a: ");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b: ");
b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сумма a и b равна: ");
sum = a + b;
System.Console.WriteLine(sum);
System.Console.WriteLine(a + "+" + b.ToString() + "=" + Convert.ToString(sum));
System.Console.WriteLine("{0:F2}+{1}={2:G4}", a, b, sum);
System.Console.WriteLine($"{a:F2}+{b}={sum:G4}");

// Вводятся два числа. Найти и вывести на экран максимальное из них
int max;
if (a > b)
{
    max = a;
}
else
    max = b;
System.Console.WriteLine($"max = {max}");