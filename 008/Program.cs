// Вывести на экран числа от -N до N
System.Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i;
i = -N;
while(i<=N){
    System.Console.Write(i + " ");
    i++;
}