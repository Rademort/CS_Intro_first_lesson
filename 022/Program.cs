// По двум заданным числам проверять является ли одно квадратом другого.
System.Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
bool b1 = x * x == y;
bool b2 = y * y == x;
if (b1 || b2)
{
    if (b1 == true)
    {
        System.Console.WriteLine("Число " + y + " является квадратом числа " + x);
    }
    else { System.Console.WriteLine("Число " + x + " является квадратом числа " + y); }
}
else { System.Console.WriteLine("Ни одно из чисел не является квадратом другого"); }