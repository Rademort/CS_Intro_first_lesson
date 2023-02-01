// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
System.Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    System.Console.WriteLine("В данном числе нет третьей цифры. NO");
}
else
{
    int d2; // третья цифра с конца, разряд сотен.
    d2 = number / 100 % 10;
    System.Console.WriteLine("Третья цифра числа {0} это {1}", number, d2);
}
