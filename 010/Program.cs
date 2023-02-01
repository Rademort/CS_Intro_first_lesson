// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
System.Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int lastNumber = N%10;
System.Console.WriteLine("Последняя цифра введенного числа: " + lastNumber);