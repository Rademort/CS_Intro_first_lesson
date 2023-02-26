


System.Console.Write("Введите число строк треугольника: ");
int n = Convert.ToInt32(Console.ReadLine());


for (int y = 0; y < n; y++)
{
    int c = 1;
    for (int q = 0; q < n - y; q++)
    {
        System.Console.Write("   ");
    }

    for (int x = 0; x <= y; x++)
    {
        System.Console.Write("   {0:D} ", c);
        c = c * (y - x) / (x + 1);
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}
System.Console.WriteLine();

// Перепробовал кучу вариантов и своих, и чужих - получается дикое уродство.