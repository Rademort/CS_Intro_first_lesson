// Написать программу вычисления значения функции y = sin(a). (Класс Math). 
double a, y;
System.Console.Write("Введите число: ");
a = Convert.ToDouble(Console.ReadLine());
y = Math.Sin(a);
System.Console.WriteLine("Синус числа "+a+" равен: " + y);

// тут не уточняется, синус угла или радиана.