// Вывести на экран кубы чисел от 1 до N

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
    int c;
    for(int i = 1; i <= N; i++){
        c = i * i * i;
        System.Console.Write(c + " ");
    }
