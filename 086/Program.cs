// Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

string s = "asdfaaasdf";

int CountSymbol(string s){
    int count = 0;
for (int i = 0; i < s.Length; i++)
{
    if(s[i]=='a'){
        count = count+1;
    }
}
    return count;
}

System.Console.WriteLine(CountSymbol(s));
