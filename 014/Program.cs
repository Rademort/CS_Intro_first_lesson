// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
int a , b;
System.Console.Write("Ddtlbnt число a: ");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ddtlbnt число b: ");
b = Convert.ToInt32(Console.ReadLine());
if(a%b==0){
    System.Console.WriteLine("Число a кратно числу b");
}else{
    System.Console.WriteLine("Число a не кратно числу b, остаток от деления равен:  " + a%b);
}