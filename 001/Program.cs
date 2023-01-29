// 1.С клавиатуры вводится целое число. Вывести квадрат числа 
int a;
string? s;
System.Console.Write("Введите число: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);
System.Console.WriteLine("Квадрат числа равен: " + (a * a));
