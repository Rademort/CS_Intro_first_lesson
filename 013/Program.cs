// Удалить вторую цифру целого числа введенного с клавиатуры.
System.Console.Write("Введите целое число: ");
string? number =Console.ReadLine();
if(number.Length >3){
number = number.Remove(number.Length - 2, 1);
System.Console.WriteLine(number);
int a = Convert.ToInt32(number);
System.Console.WriteLine(a);}
else {
    System.Console.WriteLine("Число не имеет третьей цифры");
}

/* понимаю, решение полная фигня. будут ошибки при вводе не цифр.
но я не смог придумать ничего умнее :((  */