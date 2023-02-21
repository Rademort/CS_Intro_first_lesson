// 
// Вывеести на экран числа от 0 до N не используя циклы
// int N = 10;
// int i = 0;
// while (i <= N)
// {
//     ++i;
//     System.Console.Write($"{i,4} ");
// }


// !!!!!! ЗАПРЕЩЕНО !!!
// metka: //произвольное название
//  System.Console.Write($"{++i,4}");
// if (i < N) goto metka; // оператор безусловного перехода

void Loop(int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i < N) Loop(i + 1, N);
}

//Loop(1, 20);

int F(int N)
{
    if (N > 0) { return F(N - 1) * N; }
    else
    { return 1; }
}

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

double Power(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else
    {
        if (b > 0)
        {
            return Power(a, b - 1) * a;
        }
        else
        {
            return Power(a, b + 1) * 1 / a;
        }
    }
}

System.Console.WriteLine(F(5));

System.Console.Write(Fibonacci(10));

System.Console.WriteLine();
System.Console.WriteLine(Power(2, 2));
System.Console.WriteLine();






