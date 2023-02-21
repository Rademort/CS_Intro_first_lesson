// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
// Принять первые числа равными 0 и 1. Использовать рекурсию.

int Fibonacci(int N)
{
    if (N == 0)
    {
        return 0;
    }
    else
    {
        if (N == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(N - 1) + Fibonacci(N - 2);
        }
    }
}

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    System.Console.Write($"{Fibonacci(i),4}");
}