// Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
// Вычислить сумму цифр введенного числа.

System.Console.WriteLine("Введите симфолы для проверки: ");
string s = Console.ReadLine();
int sum = 0;
for (int i = 0; i < s.Length; i++)
{
    if (char.IsDigit(s[i]))
    {
        sum += s[i] - 48;
    }
    else
    {
        // пропуск минуса в начале, если он есть
        if (i == 0 && s[i] == '-')
        {
            continue;
        }
        else
        {
            Console.WriteLine("Это не является верной записью целого");
            return;
        }
    }
}
Console.WriteLine("Сумма цифр числа: {0}", sum);
