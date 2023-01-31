// SС клавиатуры вводятся три числа. Найти максимальное из трех чисел
double a, b, c, max;
System.Console.WriteLine("Введите первое число: ");
a = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
b = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
c = Convert.ToDouble(Console.ReadLine());
max = a;
if(b > max){
    max = b;
}
if(c > max){
    max = c;
}
System.Console.WriteLine("Наибольшим из трех чисел является: " + max);