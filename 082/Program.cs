// C клавиатуры вводится строка разделенная точкой. 
// Подсчитать количество символов до точки

int CountSymbol(String s)
{
    int count = 0;
    if (s.Contains('.'))
    {
        for (int i = 0; i < s.Length; i++)
        {
            count = count + 1;
            if (s[i] == '.')
            {
                return count - 1;
            }
        }
        return count;
    }
    else
    {
        System.Console.WriteLine("В строке нет символа .");
        return count;
    }
}




System.Console.WriteLine("Введите строку: ");

String s = Console.ReadLine();
System.Console.WriteLine(CountSymbol(s));
