// По заданному с клавиатуры номеру дня недели вывести его название
System.Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(System.Console.ReadLine());
if(day == 1){
    System.Console.WriteLine("Заданный день недели - понедельник");
}
if(day == 2){
    System.Console.WriteLine("Заданный день недели - вторник");
}
if(day == 3){
    System.Console.WriteLine("Заданный день недели - среда");
}
if(day == 4){
    System.Console.WriteLine("Заданный день недели - четверг");
}
if(day == 5){
    System.Console.WriteLine("Заданный день недели - пятница");
}
if(day == 6){
    System.Console.WriteLine("Заданный день недели - суббота");
}
if(day == 7){
    System.Console.WriteLine("Заданный день недели - воскресенье");
}
if(day > 7){
    System.Console.WriteLine("Вы задали неверное число.");
}
