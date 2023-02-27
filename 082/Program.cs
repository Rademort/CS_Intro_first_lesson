// C клавиатуры вводится строка разделенная точкой. 
// Подсчитать количество символов до точки

int CountSymbol(String s, char c)
{
    int count = 0;
    if (s.Contains(c))
    {
        count = s.IndexOf(c);
        // for (int i = 0; i < s.Length; i++)
        // {
        //     count = count + 1;
        //     if (s[i] == c)
        //     {
        //         return count - 1;
        //     }
        // }
        return count;
    }
    else
    {
        System.Console.WriteLine($"В строке нет символа {c}");
        return count;
    }
}




System.Console.WriteLine("Введите строку: ");

String? s = Console.ReadLine();
System.Console.WriteLine(CountSymbol(s, '.'));
