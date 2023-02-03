// Дано число. Проверить кратно ли оно 7 и 23
int N = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;
if(N % a == 0 && N % b == 0){
    System.Console.WriteLine("Число " + N + " кратно 7 и 23");
}else {
    System.Console.WriteLine("Число " + N + " не кратно 7 и 23");
}