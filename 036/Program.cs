// Написать программу вычисления произведения чисел от 1 до N

int Multiplication(int N){
    int a = 1;
    for (int i = 1; i<= N; i++ ){
        a *=i;
    }
    return a;
}
System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведение чисел от 1 до {N} равно: {Multiplication(N)}");
