// //21. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.WriteLine("Введите день недели ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7) { System.Console.WriteLine($"День недели номер {day} - выходной"); }
else
{
    if (day >= 1 && day <= 5) { System.Console.WriteLine($"День недели номер {day} -рабочий день"); }
    else
        System.Console.WriteLine("Это не день недели");
}
