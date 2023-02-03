// Удалить третью цифру целого числа введенного с клавиатуры.
System.Console.Write("Введите целое число: ");
string? number =Console.ReadLine();
if(number.Length >=3){
number = number.Remove(number.Length - 2, 1);

int a = Convert.ToInt32(number);
System.Console.WriteLine(a);}
else {
    System.Console.WriteLine("Число не имеет третьей цифры");
}

//Удалить вторую цифру целого числа введенного с клавиатуры.
System.Console.WriteLine();
int N=123456789;
int counterDigit=0;
int N1=N;
while(N!=0)
{
    counterDigit++;
    N/=10;
}
int d=N1/(int)Math.Pow(10,counterDigit-3)%10;
System.Console.WriteLine(d);
int d1=N1/(int)Math.Pow(10,counterDigit-1)%10;
int n2=N1%(int)Math.Pow(10,counterDigit-2);
System.Console.WriteLine(d1*Math.Pow(10,counterDigit-2)+n2);