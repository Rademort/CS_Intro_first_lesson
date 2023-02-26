// Разбор задачи на ABC и CAB.

string s1 = "ABC";
string s2 = "CAB";

char[] a1 = s1.ToCharArray();
char[] a2 = s2.ToCharArray();
Array.Sort(a1);
Array.Sort(a2);

string s3 = new String(a1);
string s4 = new String(a2);
if (s3 == s4) System.Console.WriteLine("ДА");
else System.Console.WriteLine("НЕТ");