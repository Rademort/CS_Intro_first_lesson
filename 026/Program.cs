// Программа проверяет пятизначное число на палиндромом.

bool isPal(int n)
{
    int r = 0, nn = n;
    while (n > 0)
    {
        r = r * 10 + n % 10;
        n = n / 10;
    }
    return r == nn;
}

int n;
Console.Write("n=");
n = Convert.ToInt32(Console.ReadLine());
if (isPal(n))
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не палиндром");

